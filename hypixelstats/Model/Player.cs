using System;
namespace hypixelstats.Model
{
    public class PlayerResponse
    {
        public Player player { get; set; }
    }

    public class Player
    {
        public string uuid { get; set; }
        public string displayname { get; set; }
        public string rank { get; set; }
        public string packageRank { get; set; }
        public string newPackageRank { get; set; }
        public string monthlyPackageRank { get; set; }
        public Int64 firstLogin { get; set; }
        public Int64 lastLogin { get; set; }
        public Int64 lastLogout { get; set; }
        public Stats stats { get; set; }
    }

    public class Stats
    {

    }

    public class PlayerToUUID
    {
        public string name { get; set; }
        public string id { get; set; }
    }
}
