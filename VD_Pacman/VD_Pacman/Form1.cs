using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VD_Pacman.Properties;

namespace VD_Pacman
{
    public partial class Form1 : Form
    {
        Timer timer;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        public static Image foodImage { set; get; }
        bool[][] foodWorld;


        public Form1()
        {
            InitializeComponent();

            foodImage = new Bitmap(Resources.food2, new Size(30, 30));
            //foodImage = new Bitmap(Resources.food2, new Size(30, 30));

            foodWorld = new bool[WORLD_HEIGHT][];
            timer = new Timer();
            for (int i = 0; i < foodWorld.Length; i++)
            {
                foodWorld[i] = new bool[WORLD_WIDTH];
            }
            DoubleBuffered = true;

            timer.Interval = TIMER_INTERVAL;
            timer.Tick += new EventHandler(timer_Tick);

            newGame();
        }

        public void newGame()
        {
            pacman = new Pacman();
            this.Width = pacman.radius * 2 * (WORLD_WIDTH + 1);
            this.Height = pacman.radius * 2 * (WORLD_HEIGHT + 1);

            //centar
            pacman.posX = WORLD_WIDTH / 2;
            pacman.posY = WORLD_HEIGHT / 2;

            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    foodWorld[i][j] = true;
                }
            }


            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            foodWorld[pacman.posY][pacman.posX] = false;
            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
            Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pacman.ChangeDirection(DIRECTION.Up);
            }
            else if (e.KeyCode == Keys.Down)
            {
                pacman.ChangeDirection(DIRECTION.Down);
            }
            else if (e.KeyCode == Keys.Right)
            {
                pacman.ChangeDirection(DIRECTION.Right);
            }
            else if (e.KeyCode == Keys.Left)
            {
                pacman.ChangeDirection(DIRECTION.Left);
            }
            else
            {
                e.Handled = false;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * pacman.radius * 2 + (pacman.radius * 2 - foodImage.Height) / 2, i * pacman.radius * 2 + (pacman.radius * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }

    }
}
