using System;
namespace hypixelstats.Model
{
    public class Stats
    {
        public ArcadeStats Arcade { get; set; }
        public ArenaStats Arena { get; set; }
        public WarlordsStats Warlords { get; set; }
        public BedWarsStats BedWars { get; set; }
        public BuildBattleStats BuildBattle { get; set; }
        public DuelsStats Duels { get; set; }
        public TKRStats TKR { get; set; } // Turbo Kart Racers
        public BlitzStats Blitz { get; set; } // Blitz SG
        public CvCStats CvC { get; set; } // Cops vs Crims
        public MurderMysteryStats MurderMystery { get; set; }
        public PitStats Pit { get; set; }
        public SmashStats Smash { get; set; } // Smash Heroes
        public SkyWarsStats SkyWars { get; set; }
        public TNTStats TNT { get; set; } // TNT Games
        public MegaWallsStats MegaWalls { get; set; }
    }
}
