using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Lab2_final
{
    public class Cart
    {
        public List<Product> list { get; set; }
        public Cart()
        {
            list = new List<Product>();
        }


        public double Total()
        {
            double vkupno = 0;
            if (list.Count > 0)
            {                
                foreach (Product p in list)
                {
                    vkupno += p.Amount * p.Price;
                }               
            }
            return vkupno;
        }

        public override string ToString()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Name + " Amount: " + list[i].Amount);
            }
            return "";
        }
    }
}
