using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Lab_6
{
    public class Igrach
    {
        public string ime{ get; set; }
        public int poeni { get; set; }

        public Igrach()
        {
            ime = "";
            poeni = 0;
        }
        public string zgolemiPoen()
        {
            poeni += 1;
            return poeni.ToString();
        }

    }
}
