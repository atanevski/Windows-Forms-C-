using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Lab2_2_Final
{
    public partial class Form1 : Form
    {

        long vkupno = 0;
        StringBuilder sb = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }


        public void calculateTotal()
        {
            vkupno = 0;
            int value;
            //Golemina
            if (rb_Mala.Checked)
                if (int.TryParse(tb_Cena_Mala.Text, out value))
                    vkupno += value;
                else
                    vkupno += 0;


            if (rb_Sredna.Checked)
                if (int.TryParse(tb_Cena_Sredna.Text, out value))
                    vkupno += value;
                else
                    vkupno += 0;


            if (rb_Golema.Checked)
                if (int.TryParse(tb_Cena_Golema.Text, out value))
                    vkupno += value;
                else
                    vkupno += 0;


            //Dodatoci
            if (cb_Feferonki.Checked)
                if (int.TryParse(tb_Cena_Feferonki.Text, out value))
                    vkupno += value;
                else
                    vkupno += 0;

            if (cb_Kecap.Checked)
                if (int.TryParse(tb_Cena_Kecap.Text, out value))
                    vkupno += value;
                else
                    vkupno += 0;

            if (cb_Sirenje.Checked)
                if (int.TryParse(tb_Cena_Sirenje.Text, out value))
                    vkupno += value;
                else
                    vkupno += 0;

            //Pijalok
            int tempKol;
            int tempCena;

            int vkupnoGazirani;
            int vkupnoNegazirani;
            int vkupnoPivo;

            if (int.TryParse(tb_Kol_Gazirani.Text, out tempKol) && int.TryParse(tb_Cena_Gazirani.Text, out tempCena))
            {
                vkupnoGazirani = tempKol * tempCena;
                tb_Vk_gazirani.Text = vkupnoGazirani.ToString();
                vkupno += vkupnoGazirani;
            }
            else
            {
                tb_Vk_gazirani.Text = "";
            }


            if (int.TryParse(tb_Kol_Negazirani.Text, out tempKol) && int.TryParse(tb_Cena_Negazirani.Text, out tempCena))
            {
                vkupnoNegazirani = tempKol * tempCena;
                tb_Vk_Negazirani.Text = vkupnoNegazirani.ToString();
                vkupno += vkupnoNegazirani;
            }
            else
            {
                tb_Vk_Negazirani.Text = "";
            }


            if (int.TryParse(tb_Kol_Pivo.Text, out tempKol) && int.TryParse(tb_Cena_Pivo.Text, out tempCena))
            {
                vkupnoPivo = tempKol * tempCena;
                tb_Vk_Pivo.Text = vkupnoPivo.ToString();
                vkupno += vkupnoPivo;
            }
            else
            {
                tb_Vk_Pivo.Text = "";
            }


            //desert       
            int.TryParse(tb_Cena_Desert.Text, out value);
            vkupno += value;

            //naplata
            int razlika;
            tb_VkupnoZaNaplata.Text = vkupno.ToString();

            if (int.TryParse(tb_Naplateno.Text, out value))
            {
                razlika = value - Convert.ToInt32(tb_VkupnoZaNaplata.Text);
                tb_Za_Vrakjanje.Text = razlika.ToString();
            }
            else
                tb_Za_Vrakjanje.Text = "0";

        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void rb_cb_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void lb_Deserti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Deserti.SelectedIndex == -1)
            {

                tb_Cena_Desert.Text = "0";

            }
            if (lb_Deserti.SelectedIndex == 0)
            {

                tb_Cena_Desert.Text = "100";

            }
            if (lb_Deserti.SelectedIndex == 1)
            {

                tb_Cena_Desert.Text = "200";

            }
            if (lb_Deserti.SelectedIndex == 2)
            {
                tb_Cena_Desert.Text = "300";

            }
        }

        private void btn_Otkazi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сакате да ја откажете нарачката?", "Откажи нарачка?",
               MessageBoxButtons.YesNo, // vid na dijalogot 
               MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_Naracaj_Click(object sender, EventArgs e)
        {
            
            sb.Clear();
            if (rb_Mala.Checked)
                sb.Append("Мала Пица\n");
            if (rb_Sredna.Checked)
                sb.Append("Средна Пица\n");
            if (rb_Golema.Checked)
                sb.Append("Голема Пица\n");
            if (cb_Feferonki.Checked || cb_Sirenje.Checked || cb_Kecap.Checked)
            {
                sb.Append("\nДодатоци:");
                if (cb_Feferonki.Checked)
                    sb.Append("\n" + cb_Feferonki.Text );
                if (cb_Sirenje.Checked)
                    sb.Append("\n" + cb_Sirenje.Text);
                if (cb_Kecap.Checked)
                    sb.Append("\n" + cb_Kecap.Text);
               

            }
            bool pijalociString = false;
            if (tb_Vk_gazirani.Text != "0" && tb_Vk_gazirani.Text != "")
            {
                if (!pijalociString)
                {
                    sb.Append("\n\nПијалоци:");
                    pijalociString = true;
                }
                sb.Append("\n" + tb_Kol_Gazirani.Text + " " + label1.Text);
            }
            if (tb_Vk_Negazirani.Text != "0" && tb_Vk_Negazirani.Text != "")
            {
                if (!pijalociString)
                {
                    sb.Append("\n\nПијалоци:");
                    pijalociString = true;
                }
                sb.Append("\n" + tb_Kol_Negazirani.Text + " " + label2.Text);
            }
            if (tb_Vk_Pivo.Text != "0" && tb_Vk_Pivo.Text != "")
            {
                if (!pijalociString)
                {
                    sb.Append("\n\nПијалоци:");
                    pijalociString = true;
                }
                sb.Append("\n" + tb_Kol_Pivo.Text + " " + label3.Text);
            }

            if (lb_Deserti.SelectedIndex != -1)
            {
                sb.Append("\n\nДесерти: \n");
                sb.Append(lb_Deserti.SelectedItem);
            }
           
            
            MessageBox.Show(sb.ToString(),"Вашата нарачка" );
            
        }
    }
}
