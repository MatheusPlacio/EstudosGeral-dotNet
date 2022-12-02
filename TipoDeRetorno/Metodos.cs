using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDeRetorno
{
    public class Metodos
    {
        public string Nome(int idade)
        {
            string Nome = "Matheus";
            if (Nome.Contains("th") && idade >= 18)
            {
                Console.WriteLine("Certo");
            }
            return Nome;
        }
    }
}
