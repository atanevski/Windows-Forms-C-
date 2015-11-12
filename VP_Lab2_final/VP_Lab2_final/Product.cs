using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Lab2_final
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public string display { get; set; }

        public Product()
        {
            this.Name = "";
            this.Category = "";
            this.Price = 0;
            this.Amount = 0;

        }
        
        public Product(string Name, string Category, double Price, int Amount)
        {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
            this.Amount = Amount;

        }

        public Product(string Name, string Category, double Price)
        {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
            this.Amount = 0;

        }

        public override string ToString()
        {
            return Name;
        }

        public double totalPrice()
        {
            return Price * (double)Amount;
        }

        

        //public void refreshDisplay()
        //{
        //    display = Name + " " + Amount + " x " + Price + " = " + Price * (double)Amount;
        //}

    }
}
