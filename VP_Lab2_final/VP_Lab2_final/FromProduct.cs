using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Lab2_final
{
    public partial class FromProduct : Form
    {
        public Product NewProduct { get; set; }
        public FromProduct()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            double dPrice;
            double.TryParse(tb_Price.Text, out dPrice);
            NewProduct = new Product(tb_Name.Text, tb_Category.Text, dPrice);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void tb_Name_Validating(object sender, CancelEventArgs e)
        {
            if (tb_Name.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tb_Name, "Внесете име!");
            }
            else
            {
                errorProvider1.SetError(tb_Name, null);
            }
        }
    }
}
