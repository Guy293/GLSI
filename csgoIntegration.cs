using CSGSI;
using System;

namespace GLSI
{
    public class CsgoIntegration
    {
        public static bool ToCountKills = false;
        public static bool ToCountDeaths = false;
        public static bool ToCountAssists = false;

        // Set game state listener to http://localhost:6996/
        public GameStateListener gsl;

        public CsgoIntegration()
        {
            // Set game event handler to function
            GameStateListener gsl = new GameStateListener(6996);
            gsl.NewGameState += OnNewGameState;
            gsl.Start();
        }

        void OnNewGameState(GameState gs)
        {
            //TODO save to program folder

            if (ToCountKills &&
                (gs.Previously.Player.MatchStats.Kills != gs.Added.Player.MatchStats.Kills) &&
                gs.Player.MatchStats.Kills != -1)
            {
                //File.WriteAllText("C:\\Users\\gshef\\Desktop\\kills.txt", gs.Player.MatchStats.Kills.ToString());

                Console.WriteLine(gs.Player.MatchStats.Kills);
            }

            if (ToCountDeaths &&
                (gs.Previously.Player.MatchStats.Deaths != gs.Added.Player.MatchStats.Deaths) &&
                gs.Player.MatchStats.Deaths != -1)
            {
                Console.WriteLine(gs.Player.MatchStats.Deaths);
            }

            if (ToCountAssists &&
                (gs.Previously.Player.MatchStats.Assists != gs.Added.Player.MatchStats.Assists) &&
                gs.Player.MatchStats.Assists != -1)
            {
                Console.WriteLine(gs.Player.MatchStats.Assists);
            }
        }
    }

}
