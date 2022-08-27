using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenght___SubString
{
    public class Metodos
    {
        public void Nome(string nome)
        {
            Console.WriteLine("O nome Matheus tem " + nome.Length + " Letras");
        }

        public void Nom(string nome)
        {
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i] + "\n");
            }
        }

        public void nOme()
        {
            string nome = "Matheus Placio Babo";
            Console.WriteLine(nome.Substring(8));
        }
    }
}
