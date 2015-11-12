using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{
    abstract class Game
    {
        protected Grid grid;

        public int CurrentGeneration { get; set; }

        public int MaxGenerations { get; set; }
        public Game(int maxGenerations)
        {
            CurrentGeneration = 0;
            this.MaxGenerations = maxGenerations;
        }

        public void Evolve()
        {
            grid.Evolve();
            CurrentGeneration++;
        }

        virtual public void Show()
        {
            Console.Clear();
            Console.WriteLine("Current Generation : {0}", CurrentGeneration);
            for (int i = 0; i < grid.Rows; i++)
            {
                for (int j = 0; j < grid.Columns; j++)
                {
                    Console.Write(grid.Cells[i][j].ToString());
                }
                Console.WriteLine();
            }
        }




    }
}