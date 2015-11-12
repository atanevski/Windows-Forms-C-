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
    public partial class Form1 : Form
    {
        public Products products { get; set; }
        public Cart cart { get; set; }
        public Form1()
        {
            InitializeComponent();
            products = new Products();
            cart = new Cart();
            refreshTotal();

        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            FromProduct newFormProduct = new FromProduct();
            if (newFormProduct.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Product tempP = newFormProduct.NewProduct;
                Product clone = new Product(tempP.Name, tempP.Category, tempP.Price);
                products.list.Add(clone);
                newFormProduct.Close();
                refreshProductsList();
            }
            else
            {
                newFormProduct.Close();
            }

        }

        private void btn_DeleteFromCart_Click(object sender, EventArgs e)
        {

            if (lb_Cart.SelectedIndex != -1)
            {
                Product tempP = (Product)lb_Cart.SelectedItem;
                bool deleteItem = cart.list.Remove(tempP);
                //Console.WriteLine("DeleteFromCart -->" + deleteItem);
                refreshCartList();
                refreshTotal();
            }

        }
        public void refreshProductsList()
        {
                lb_Products.Items.Clear();
                for (int i = 0; i < products.list.Count; i++)
                {
                    lb_Products.Items.Add(products.list[i]);
                }        
        }

        public void refreshTextBoxes()
        {
            if (lb_Products.SelectedIndex == -1)
            {
                tb_Category.Text = "";
                tb_Name.Text = "";
                tb_Price.Text = "";
            }
            else
            {
                Product tempP = (Product)lb_Products.SelectedItem;
                tb_Name.Text = tempP.Name;
                tb_Price.Text = tempP.Price.ToString();
                tb_Category.Text = tempP.Category;
            }
        }

        public void refreshCartList()
        {
            lb_Cart.Items.Clear();
            for (int i = 0; i < cart.list.Count; i++)
            {
                Product tempP = cart.list[i];
                tempP.display = tempP.Name + " " + tempP.Amount + " x " + tempP.Price + " = " + tempP.totalPrice();
                lb_Cart.DisplayMember = "display";
                lb_Cart.Items.Add(cart.list[i]);

            }
        }

        public void refreshTotal()
        {
            tb_Total.Text = String.Format("{0:0.00}", (double)cart.Total());
            //Console.WriteLine("refTotal");
        }

        private void lb_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTextBoxes();
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (lb_Products.SelectedIndex != -1)
            {
                Product tempP = (Product)lb_Products.SelectedItem;
                bool deleteItem = products.list.Remove(tempP);
                //Console.WriteLine(deleteItem);
                refreshProductsList();
                refreshTextBoxes();
            }
        }

        private void btn_AddtoCart_Click(object sender, EventArgs e)
        {
            if (lb_Products.SelectedIndex != -1)
            {
                Product tempP = (Product)lb_Products.SelectedItem;
                Product clone = new Product(tempP.Name, tempP.Category, tempP.Price, (int)nud_Amount.Value);
                cart.list.Add(clone);
                refreshCartList();
                refreshTotal();
            }
        }
        
        private void btn_ClearCart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни ?", "Избриши цела кошничка",
            MessageBoxButtons.YesNo, // vid na dijalogot 
            MessageBoxIcon.Warning); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                cart.list.Clear();
                refreshCartList();
                refreshTotal();
            }
        }

        private void btn_ClearProducts_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни ?", "Избриши цела листа на продукти",
            MessageBoxButtons.YesNo, // vid na dijalogot 
            MessageBoxIcon.Warning); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                products.list.Clear();
                refreshProductsList();
                refreshTextBoxes();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(cart.list[0].GetHashCode());
            //Console.WriteLine(cart.list[1].GetHashCode());
        }


    }
}
