using System;
namespace hypixelstats.Model
{
    public class WarlordsStats
    {
        public int coins { get; set; }
        public int kills { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public double kill_death_ratio { get; set; }
        public int wins { get; set; }
        public int wins_domination { get; set; }
        public int wins_capturetheflag { get; set; }
        public int wins_teamdeathmatch { get; set; }
    }
}
