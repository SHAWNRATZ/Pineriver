using CSGSI;
using CSGSI.Nodes;
using System;

namespace CSGOTEST
{
    class Program
    {
        static GameStateListener gsl;

        static bool IsPlanted = false;

        static void Main(string[] args)
        {
            gsl = new GameStateListener(3000);
            gsl.NewGameState += new NewGameStateHandler(OnNewGameState);
            if (!gsl.Start())
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Listening...");
        }

        static void OnNewGameState(GameState gs)
        {
            if (gs.Round.Phase == RoundPhase.Live &&
               gs.Bomb.State == BombState.Planted &&
               gs.Previously.Bomb.State == BombState.Planting)
            {
                Console.WriteLine("Bomb has been planted.");
                IsPlanted = true;
            }
        }
    }
}
