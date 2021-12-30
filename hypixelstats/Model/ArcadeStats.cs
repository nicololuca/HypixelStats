namespace hypixelstats.Model
{
    public class ArcadeStats
    {
        public int coins { get; set; }
        public Arcade_BlockingDead blocking_dead { get; set; }
        public Arcade_DragonWars dragonwars { get; set; }
        public Arcade_HypixelSays hypixel_says { get; set; }
        public Arcade_HypixelSays santa_says { get; set; }
        public Arcade_MiniWalls miniwalls { get; set; }
        public Arcade_PartyGames party_games { get; set; }
        public Arcade_BountyHunters bounty_hunters { get; set; }
        public Arcade_GalaxyWars galaxy_wars { get; set; }
        public Arcade_FarmHunt farm_hunt { get; set; }
        public Arcade_Football football { get; set; }
        public Arcade_CreeperAttack creeper_attack { get; set; }
        public Arcade_HITW hole_in_the_wall { get; set; }
        public Arcade_Zombies zombies { get; set; }
    }

    public class Arcade_BlockingDead
    {
        public int wins { get; set; }
        public int zombie_kills { get; set; }
        public int headshots { get; set; }
    }

    public class Arcade_DragonWars
    {
        public int wins { get; set; }
        public int kilsl { get; set; }
    }

    public class Arcade_HypixelSays
    {
        public int wins { get; set; }
        public int rounds { get; set; }
    }

    public class Arcade_MiniWalls
    {
        public int wins { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int final_kills { get; set; }
        public int arrows_shot { get; set; }
        public int arrows_hit { get; set; }
        public int wither_damage { get; set; }
        public int wither_kills { get; set; }
        public string kit { get; set; }
    }

    public class Arcade_PartyGames
    {
        public int wins_1 { get; set; }
    }

    public class Arcade_BountyHunters
    {
        public int wins { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int bounty_kills { get; set; }
    }

    public class Arcade_GalaxyWars
    {
        public int wins { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int rebel_kills { get; set; }
        public int shots_fired { get; set; }
    }

    public class Arcade_FarmHunt
    {
        public int wins { get; set; }
        public int poop_collected { get; set; }
    }

    public class Arcade_Football
    {
        public int wins { get; set; }
        public int goals { get; set; }
        public int powerkicks { get; set; }
    }

    public class Arcade_CreeperAttack
    {
        public int best_wave { get; set; }
    }

    public class Arcade_HITW
    {
        public int wins { get; set; }
        public int rounds { get; set; }
        public int highest_score_qualification { get; set; }
        public int highest_score_finals { get; set; }
    }

    public class Arcade_Zombies
    {
        public int wins { get; set; }
        public int zombie_kills { get; set; }
        public int deaths { get; set; }
        public int total_rounds_survived { get; set; }
        public int bullets_hit { get; set; }
        public int headshots { get; set; }
        public int players_revived { get; set; }
        public int windows_repaired { get; set; }
        public int doors_opened { get; set; }
        public int best_round { get; set; }
    }
}