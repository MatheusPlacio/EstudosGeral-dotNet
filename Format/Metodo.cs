using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    public class Metodo
    {
        public void Hora()
        {
            string s = String.Format("Hoje é {0:D} e são {0:T}", DateTime.Now);
            Console.WriteLine(s);
        }
    }
}
