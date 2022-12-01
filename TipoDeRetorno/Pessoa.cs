using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDeRetorno
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CorDePele { get; set; }
        public string Magro { get; set; }
        public string Obeso { get; set; }
        public decimal altura { get; set; }
        public List<Carros> Carros { get; set; }
    }
}
