using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace VP_Lab_6
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int[] broevi = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
        string[] znak = new string[4] { "+", "-", "*", "/" };

        Equation tekovna = new Equation();
        List<Igrach> igraci = new List<Igrach>();
        Igrach tekovenIgrac;

        private Timer _timer = new Timer();
        private Timer _timerMin = new Timer();
        private Stopwatch stoperka = new Stopwatch();

        TimeSpan ednaMin;
        TimeSpan ts;
        bool firstRun = true;

        int pogodeni = 0;
        int pogodeniVkupno = 0;   
        int nonameplayer = 0;

        public Form1()
        {
            InitializeComponent();
            _timer.Interval = 1000;
            _timerMin.Interval = 3600000;
            _timer.Tick += new EventHandler(_timer_Tick);
        }     
        
        //magic
        private void generirajPredizvik()
        {
            tekovna.prvBroj = random.Next() % 10;
            tekovna.vtorBroj = random.Next(tekovna.prvBroj);
            tekovna.operand = znak[(int)random.Next() % 3];
            tekovna.presmetaj();
            osvezi();
        }
        private void osvezi()
        {
            tb_prvArgument.Text = tekovna.prvBroj.ToString();
            tb_VtorArgument.Text = tekovna.vtorBroj.ToString();
            tb_Znak.Text = tekovna.operand.ToString();
            lbl_Poeni.Text = tekovenIgrac.poeni.ToString();
            pb_Poeni.Value = Int32.Parse(lbl_Poeni.Text);
        }
        private void resetiraj()
        {
            tb_prvArgument.Text = "";
            tb_VtorArgument.Text = "";
            tb_Znak.Text = "";
            lbl_Poeni.Text = "0";
            tb_Rezultat.Text = "";
            pb_Poeni.Value = Int32.Parse(lbl_Poeni.Text);
        }
        private void initNajdobri()
        {
            btn_Kraj.Visible = false;
            btn_NovaIgra.Visible = true;

            tb_Igrac.Text = "";

            _timer.Stop();
            pb_Vreme.Value = 0;
            lbl_Vreme.Text = "";

            resetiraj();
        }
        private void checkTimer()
        {
            if (_timer.Enabled)
            {
                btn_NovaIgra.Visible = false;
                btn_Kraj.Visible = true;
            }
            if (!_timer.Enabled)
            {
                btn_NovaIgra.Visible = true;
                btn_Kraj.Visible = false;
            }
        }
        private void resetANDstartTimers()
        {
            stoperka.Reset();
            _timer.Interval = 1000;
            _timerMin.Interval = 3600000;
            stoperka.Start();
            _timer.Start();
        }

        //Buttons
        private void btn_Iskluci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Najdobri_Click(object sender, EventArgs e)
        {
            initNajdobri();
            igraci = igraci.OrderByDescending(x => x.poeni).ToList();

            string temp = "";
            foreach (Igrach item in igraci)
            {
                temp += item.ime + " : " + item.poeni + "\n";
                
            }
            DialogResult resultasd = MessageBox.Show(temp,"Најдобри играчи", MessageBoxButtons.OK);

            
        }
        private void btn_Pogodi_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(tb_Rezultat.Text) && !String.IsNullOrWhiteSpace(tb_Znak.Text))
            {
                Console.WriteLine("wroking {0} {1}", tb_Rezultat.Text, tekovna.rezultat);

                if (tb_Rezultat.Text.ToString().Equals(tekovna.rezultat.ToString()))
                {
                    lbl_Poeni.Text = tekovenIgrac.zgolemiPoen();
                    pb_Poeni.Value = Int32.Parse(lbl_Poeni.Text);
                    pogodeniVkupno++;
                    if (pogodeniVkupno % 10 == 0)
                    {
                        pogodeni++;
                    }

                }
                tb_Rezultat.Clear();
                tb_Rezultat.Focus();
                generirajPredizvik();
            }
        
        }
        private void btn_NovaIgra_Click(object sender, EventArgs e)
        {
            checkTimer();

            if (string.IsNullOrWhiteSpace(tb_Igrac.Text))
            {
                tb_Igrac.Text = "NoName" + nonameplayer.ToString();
                nonameplayer++;
            }
            if (firstRun == true)
            {
                tekovenIgrac = new Igrach();
                tekovenIgrac.ime = tb_Igrac.Text;
                generirajPredizvik();
                firstRun = false;
            }
            else
            {
                tekovenIgrac = new Igrach();
                tekovenIgrac.ime = tb_Igrac.Text;
                generirajPredizvik();
                osvezi();

            }
            tb_Rezultat.Text = "";
            tb_Rezultat.Focus();

            igraci.Add(tekovenIgrac);

            resetANDstartTimers();

            checkTimer();
        }
       

        //Tik Tac
        private void _timer_Tick(object sender, EventArgs e)
        {
            ednaMin = TimeSpan.FromMinutes(1) + TimeSpan.FromSeconds(10*pogodeni) + TimeSpan.FromSeconds(1);
            ts = ednaMin - stoperka.Elapsed;

            string test = string.Format("{0}:{1}", Math.Floor(ts.TotalMinutes), ts.ToString("ss"));
            lbl_Vreme.Text = test;
            pb_Vreme.Maximum = 60 + 10*pogodeni;
            pb_Vreme.Value = ts.Minutes*60 + ts.Seconds ;
            //Console.WriteLine(pb_Vreme.Value);
            if (pb_Vreme.Value == 0)
            {
                btn_Najdobri.PerformClick();
            }

        }

    }
}
