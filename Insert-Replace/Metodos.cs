using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_Replace
{
    public class Metodos
    {
        public void Inserir(string nome)
        {
            Console.WriteLine(nome.Insert(0, "Matheus "));
        }

        public void Ins()
        {
            string nome = "Placio";
            Console.WriteLine(nome.Insert(0, "Matheus "));
        }

        public static string Inser(string nome)
        {
            nome = "Placio";
            Console.WriteLine(nome.Insert(0, "Matheus "));
            return nome;
        }

        public void Repl()
        {
            string nome = "Matheus Babo";
            // o Replace ele substitui, no caso vai substituir o Babo pelo Placio
            string nomeFinal = nome.Replace("Babo", "Placio");
            Console.WriteLine(nomeFinal);          
        }

      
    }
}
