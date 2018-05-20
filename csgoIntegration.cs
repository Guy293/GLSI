using CSGSI;
using System;

namespace GLSI
{
    class CsgoIntegration
    {
        public static bool toCountKills = false;
        public static bool ToCountDeaths = false;

        CsgoIntegration()
        {
            // Set game state listener to http://localhost:6969/
            GameStateListener gsl = new GameStateListener(6969);
            // Set game event handler to function
            gsl.NewGameState += OnNewGameState;
            Console.WriteLine(gsl.Start());
        }

        void OnNewGameState(GameState gs)
        {
            Console.WriteLine(gs.JSON);
            //TODO save to program folder
            if (gs.Previously.Player.MatchStats.Kills != gs.Added.Player.MatchStats.Kills)
            {
                if (toCountKills)
                {
                    //File.WriteAllText("C:\\Users\\gshef\\Desktop\\kills.txt", gs.Player.MatchStats.Kills.ToString());

                    Console.WriteLine(gs.Player.MatchStats.Kills);
                }

                if (ToCountDeaths)
                {
                    Console.WriteLine(gs.Player.MatchStats.Deaths);
                }
            }
        }
    }

}
