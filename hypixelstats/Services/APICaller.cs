using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.ObjectModel;
using hypixelstats.Model;
using hypixelstats.Exceptions;
using Newtonsoft.Json;

namespace hypixelstats.Services
{
    public class APICaller: IAPICaller
    {
        private readonly static string BaseURL = "https://api.slothpixel.me/api/";

        public APICaller()
        {
        }

        /*
         * This function has two API calls in it: one that gets the player's UUID via
         * the Mojang API, and one that gets the player's information via the Slothpixel
         * Public API.
         */

        public async Task<Player> GetPlayer(string playerName)
        {
            Console.WriteLine("APICaller - Chiamata GetPlayer() async");
            string uuid;
            try
            {
                uuid = await GetPlayerUUID(playerName);
            }
            catch(NoContentException e)
            {
                Console.WriteLine($"APICaller - error while getting player's UUID: {e.Message}");
                return null;
            }

            if (uuid != null)
            {
                Console.WriteLine("APICaller - Player UUID: " + uuid);
                string CompleteUrl = BaseURL + $"players/{uuid}?key={Keys.APIKey}";
                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(CompleteUrl);

                var result = await response.Content.ReadAsStringAsync();
                var resultSuccess = JsonConvert.DeserializeObject<Player>(result);

                return resultSuccess;
            }

            return null;
        }

        public async Task<string> GetPlayerUUID(string playerName)
        {
            string RequestUrl = $"https://api.mojang.com/users/profiles/minecraft/{playerName}";
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(RequestUrl);

            Console.WriteLine($"GetPlayerUUID - {response.StatusCode}");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();

                var json = JsonConvert.DeserializeObject<PlayerToUUID>(result);

                Console.WriteLine($"GetPlayerUUID - Risultato dell'UUID: {json.id}");

                return json.id;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                throw new NoContentException("Errore nel recupero dell'UUID.");
            }

            return null;
        }
    }
}
    
