using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{
    class Grid
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[][] Cells { get; set; }

        public Grid(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            Cells = new Cell[rows][];

            for (int i = 0; i < Rows; i++)
            {
                Cells[i] = new Cell[Columns];
                for (int j = 0; j < Columns; j++)
                {
                    Cells[i][j] = new Cell();
                }
            }

        }

        public void ToggleCell(int x, int y, bool isAlive)
        {
            Cells[x][y].IsAlive = isAlive;
        }

        private bool isAlive(int x, int y)
        {
            if ((x < 0 || x >= Rows || y < 0 || y >= Columns)){
                return false;
            }

            else if (Cells[x][y].IsAlive)
            {
                return true;
            }
                

            return false;
        }

        public void Evolve()
        {

            for (int i = 0; i < this.Rows; i++)
                for (int j = 0; j < this.Columns; j++)
                {
                    int br = 0;
                    int x, y;

                    x = i - 1;
                    y = j;
                    if (isAlive(x, y))
                        br++;

                    y = j - 1;
                    if (isAlive(x, y))
                        br++;

                    y = j + 1;
                    if (isAlive(x, y))
                        br++;

                    x = i;
                    y = j - 1;
                    if (isAlive(x, y))
                        br++;

                    y = j + 1;
                    if (isAlive(x, y))
                        br++;

                    x = i + 1;
                    y = j;
                    if (isAlive(x, y))
                        br++;

                    y = j + 1;
                    if (isAlive(x, y))
                        br++;

                    y = j - 1;
                    if (isAlive(x, y))
                        br++;




                    if (br < 2){
                        Cells[i][j].ShouldLive = false;
                    }                        
                    else if (br > 3){
                        Cells[i][j].ShouldLive = false;
                    }
                    else
                    {
                        Cells[i][j].ShouldLive = true;
                    }
                       


                }

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Cells[i][j].IsAlive = Cells[i][j].ShouldLive;
                }
                    
            }
                
        }
    }
}