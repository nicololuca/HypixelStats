using System;
namespace hypixelstats.Model
{
    public class Player
    {
        public string uuid { get; set; }
        public string username { get; set; }
        public string[] name_history { get; set; }
        public bool online { get; set; }
        public string rank { get; set; }
        public string rank_plus_color { get; set; }
        public string rank_formatted { get; set; }
        public string prefix { get; set; }
        public int karma { get; set; }
        public int exp { get; set; }
        public double level { get; set; }
        public int achievement_points { get; set; }
        public int quests_completed { get; set; }
        public int total_kills { get; set; }
        public int total_wins { get; set; }
        public int total_coins { get; set; }
        public Int64 first_login { get; set; }
        public Int64? last_login { get; set; }
        public Int64? last_logout { get; set; }
        public string last_minigame { get; set; }
        public string language { get; set; }
        public int gifts_sent { get; set; }
        public int gifts_received { get; set; }
        public Links links { get; set; }
        public Stats stats { get; set; }
    }

    public class Links
    {
        public string TWITTER { get; set; }
        public string YOUTUBE { get; set; }
        public string INSTAGRAM { get; set; }
        public string TWITCH { get; set; }
        public string DISCORD { get; set; }
        public string HYPIXEL { get; set; }
    }

    public class PlayerToUUID
    {
        public string name { get; set; }
        public string id { get; set; }
    }
}
