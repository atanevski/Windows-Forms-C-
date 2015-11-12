using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{

    class Program
    {
        static readonly int MAX_GENERATIONS = 13;

        static void Main(string[] args)
        {
            Game game = new OscilatorGame(OscilatorGame.GameType.Beacon, MAX_GENERATIONS);
            while (game.CurrentGeneration <= game.MaxGenerations)
            {
                game.Show();
                game.Evolve();
                Thread.Sleep(100);
            }
            Console.WriteLine("Evaluation ended!\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}