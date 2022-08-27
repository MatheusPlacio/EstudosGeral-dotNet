using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Metodos
    {
        public static void Alunos()
        {
           Dictionary<int, string> alunos = new();
            alunos.Add(10, "Matheus");
            alunos.Add(8, "Danny");
            alunos.Add(9, "Silva");
            alunos.Add(7, "Souza");
            alunos.Add(6, "Mendes");

         
            foreach (var aluno in alunos)
            {
                if (aluno.Key >= 7)
                    Console.WriteLine(aluno.Key + "-" + aluno.Value);
            }
        }
        
        
    }
}
