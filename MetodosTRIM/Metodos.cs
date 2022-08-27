using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosTRIM
{
    public class Metodos
    {
        public void SemEspaco()
        {
            //O trim remove os espaços e tambem os caracteres que eu definir
            char[] c = { ' ', '-', '_', '5' };
            string nome = "Matheus";
            string novo = nome.Trim(c);
            Console.WriteLine(novo);
        }


    }
}
