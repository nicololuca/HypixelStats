using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.ObjectModel;
using hypixelstats.Model;
using Newtonsoft.Json;

namespace hypixelstats.Services
{
    public class APICaller: IAPICaller
    {
        private readonly static string BaseURL = "https://api.hypixel.net/";

        public APICaller()
        {
        }

        /*
         * This functions has two API calls in it: one that gets the player's UUID via
         * the Mojang API, and one that gets the player's information via the Hypixel
         * Public API.
         * As the Hypixel API returns different objects based on the first element of
         * its json object (success), I've created a model that only reads that element
         * and then decode the remaining elements according to the success' value.
         * 
         * Example of responses:
         * 
         * 200 - OK
         * {
         *      "success": true,
         *      "player": { ... }
         * }
         * 
         * 400 - Some data is missing
         * {
         *      "success": false,
         *      "cause": "..."
         * }
         * 
         * 403 - Forbidden, usually caused by an invalid API Key
         * {
         *      "success": false,
         *      "cause": "..."
         * }
         * 
         * 429 - Request limit or global throttle
         * {
         *      "success": false,
         *      "cause": "...",
         *      "throttle": <boolean>,
         *      "global": <boolean>
         * }
         */

        public async Task<Player> GetPlayer(string playerName)
        {
            string uuid = await GetPlayerUUID(playerName);
            if (uuid != null)
            {
                string CompleteUrl = BaseURL + $"player?uuid{uuid}";
                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(CompleteUrl);

                var result = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<APISuccessModel>(result);

                if (json.success)
                {
                    var resultSuccess = JsonConvert.DeserializeObject<PlayerResponse>(result);
                    return resultSuccess.player;
                }
                else
                {
                    var resultFailure = JsonConvert.DeserializeObject<APIFailureModel>(result);
                    Console.WriteLine(resultFailure.cause);
                }
            }

            return null;
        }

        public async Task<string> GetPlayerUUID(string playerName)
        {
            string RequestUrl = $"https://api.mojang.com/users/profiles/minecraft/{playerName}";
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(RequestUrl);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();

                var json = JsonConvert.DeserializeObject<PlayerToUUID>(result);

                return json.uuid;
            }

            return null;
        }
    }
}
    
