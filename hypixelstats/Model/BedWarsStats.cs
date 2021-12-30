using System;
namespace hypixelstats.Model
{
    public class BedWarsStats
    {
        public int coins { get; set; }
        public int exp { get; set; }
        public int level { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int games_played { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public double k_d { get; set; }
        public double w_l { get; set; }
        public int beds_broken { get; set; }
        public int beds_lost { get; set; }
        public int final_kills { get; set; }
        public int final_deaths { get; set; }
        public double final_k_d { get; set; }
        public int winstreak { get; set; }
    }
}
