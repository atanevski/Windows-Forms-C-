using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Lab_6
{
    public class Equation
    {
        public int prvBroj { get; set; }
        public int vtorBroj { get; set; }

        public string operand { get; set; }
        public int rezultat { get; set; }


        public Equation()
        {

        }

        public Equation(int a,string znak, int b)
        {
            prvBroj = a;
            vtorBroj = b;
            operand = znak;
            if (operand == "+")
            {
                rezultat = a + b;
            }
            if (operand == "-")
            {
                rezultat = a - b;
            }
            if (operand == "*")
            {
                rezultat = a * b;
            }
            if (operand == "/")
            {
                rezultat = a / b;
            }
        }

        public void presmetaj()
        {
            if (operand == "+")
            {
                rezultat = prvBroj + vtorBroj;
            }
            if (operand == "-")
            {
                rezultat = prvBroj - vtorBroj;
            }
            if (operand == "*")
            {
                rezultat = prvBroj * vtorBroj;
            }
            if (operand == "/")
            {
                rezultat = prvBroj / vtorBroj;
            }
        }
    }
}
