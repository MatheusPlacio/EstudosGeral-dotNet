using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpper___ToLower
{
    public class UpperLower
    {
        //sem parametro
        public void NOme()
        {
            string nome = "Matheus";
            Console.WriteLine("Meu nome é: " + nome.ToUpper());
        }
        
        // com parametro
        public void NOME(string nome)
        {
            Console.WriteLine("Meu nome é: " + nome.ToUpper());
        }
        
        // com parametro
        public static void nome(string nome)
        {
            Console.WriteLine("Meu nome é: " + nome.ToUpper());
        }
        
        // sem parametro
        public string MeuNome()
        {
           string nome = "Matheus";
            Console.WriteLine("Meu nome é: " + nome.ToLower());
            return nome;
        }

        //com parametro estatico
        public static string MeuNoMe(string nome)
        {
            Console.WriteLine("Meu nome é: " + nome.ToLower());
            return nome;
        }




    }
}
