using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsToString
{
    public class MétodoConter
    {
        public void Contem(string texto)
        {
            if (texto.Contains("melhor"))
            {
                Console.WriteLine("Contém");
            }
            else
            {
                Console.WriteLine("Não contém");
            }
        }

        public static void Contemm(string texto)
        {
            if (texto.Contains("melhor"))
            {
                Console.WriteLine("Contém");
            }
            else
            {
                Console.WriteLine("Não contém");
            }
        }


    }
}