using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VD_Pacman
{
    public enum DIRECTION
    {
        Up,
        Down,
        Left,
        Right
    }
    public class Pacman
    {
        public int posX { get; set; }
        public int posY { get; set; }

        public DIRECTION direction { get; set; }
        public int radius = 20;
        public int speed { get; set; }
        public bool isMouthOpen { get; set; }
        Brush brush;


        public Pacman()
        {
            this.speed = this.radius;
            direction = DIRECTION.Right;
            brush = new SolidBrush(Color.Yellow);
        }




        public void ChangeDirection(DIRECTION direction)
        {
            this.direction = direction;
        }




        public void Move(int width, int height)
        {
            isMouthOpen = !isMouthOpen;

            //levo desno
            if (direction == DIRECTION.Right)
            {
                if (posX < width - 1)
                {
                    posX++;
                }
                else
                {
                    posX = 0;
                }
            }
            else if (direction == DIRECTION.Left)
            {
                if (posX > 0)
                {
                    posX--;
                }
                else
                {
                    posX = width - 1;
                }
            }



            //gore dolu
            if (direction == DIRECTION.Up)
            {
                if (posY > 0)
                {
                    posY--;
                }
                else
                {
                    posY = height - 1;
                }
            }

            else if (direction == DIRECTION.Down)
            {
                if (posY < height-1)
                {
                    posY++;
                }
                else
                {
                    posY = 0;
                }
            }

        }


        public void Draw(Graphics g)
        {

            int X = posX * radius * 2;
            int Y = posY * radius * 2;
            int width = Form1.foodImage.Height + Form1.foodImage.Height / 2;
            int height = Form1.foodImage.Width + Form1.foodImage.Width / 2;

            if (isMouthOpen)
            {
                if (direction == DIRECTION.Right)
                {
                    g.FillPie(brush, X, Y, width, height, 30, 310);
                }

                if (direction == DIRECTION.Left)
                {
                    g.FillPie(brush, X, Y, width, height, 210, 310);
                }

                if (direction == DIRECTION.Up)
                {
                    g.FillPie(brush, X, Y, width, height, 300, 310);
                }

                if (direction == DIRECTION.Down)
                {
                    g.FillPie(brush, X, Y, width, height, 120, 310);
                }
            }
            else
            {
                g.FillPie(brush, X, Y, width, height, 0, 360);
            }
        }

    }
}
