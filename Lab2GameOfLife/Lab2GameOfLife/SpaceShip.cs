using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{
    class SpaceShip : Game
    {
        public enum GameType
        {
            Lightweight
        }

        public GameType Type { get; set; }

        public SpaceShip(GameType gameType, int maxGenerations)
            : base(maxGenerations)
        {
            Type = gameType;
            if (gameType == GameType.Lightweight)
            {
                grid = new Grid(6, 20);
                grid.ToggleCell(2, 4, true);
                grid.ToggleCell(2, 5, true);
                grid.ToggleCell(3, 2, true);
                grid.ToggleCell(3, 3, true);
                grid.ToggleCell(3, 5, true);
                grid.ToggleCell(3, 6, true);
                grid.ToggleCell(4, 2, true);
                grid.ToggleCell(4, 3, true);
                grid.ToggleCell(4, 4, true);
                grid.ToggleCell(4, 5, true);
                grid.ToggleCell(5, 3, true);
                grid.ToggleCell(5, 4, true);
            }
        }

        override public void Show()
        {
            Console.Title = String.Format("SpaceShip Game of Life: {0}", Type);
            base.Show();
        }
    }
}
