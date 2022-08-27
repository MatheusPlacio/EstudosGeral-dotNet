using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    public class Metodos
    {
        public static void Nome()
        {
            string nomes = "Matheus Marcos Lucas João Anjo";

            char[] separador = { ' ' };

            string[] resultado = nomes.Split(separador);

            foreach(string nome in resultado)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
