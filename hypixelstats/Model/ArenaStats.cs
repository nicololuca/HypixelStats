using System;
namespace hypixelstats.Model
{
    public class ArenaStats
    {
        public int coins { get; set; }
        public Arena_Gamemodes gamemodes { get; set; }
    }

    public class Arena_Gamemodes
    {
        public Arena_Gamemodes_Stats one_v_one { get; set; }
        public Arena_Gamemodes_Stats two_v_two { get; set; }
        public Arena_Gamemodes_Stats four_v_four { get; set; }
    }

    public class Arena_Gamemodes_Stats
    {
        public int kills { get; set; }
        public int deaths { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int win_streaks { get; set; }
        public int games { get; set; }
        public double kd { get; set; }
        public double win_loss { get; set; }
    }
}
