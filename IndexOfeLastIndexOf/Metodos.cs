using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfeLastIndexOf
{
    public class Metodos
    {
        public void Nome(string nome)
        {

            if (nome.IndexOf('t') == 2) 
            {
                Console.WriteLine("Certo");
            }
            else
            {
                Console.WriteLine("Errado");
            }
        }

        public void MeuNome(string nome)
        {
            Console.WriteLine("A letra 's' é a posição: " + nome.IndexOf('s'));
        }

        public static void uNome()
        {
            string nome = "Matheus";
            Console.WriteLine("A letra 's' é a posição: " + nome.IndexOf('s'));
        }
        public static string Nomeu()
        {
            string nome = "Matheus Placio Babo";
            Console.WriteLine("A letra 'o' é a posição: " + nome.LastIndexOf('o'));
            return nome;
        }

        
    }
}
