using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    // quando a classe é static todos os seus membros devem ser estaticos também
    static class Matematica
    {
        public static int Taxa { get; set; }

        public static int Adicionar(int valor)
        {
            return valor + Taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - Taxa;
        }
    }
}
