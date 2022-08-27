using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    public class Pessoa
    {
        public static int _numeroDePessoas = 0;
        public string Nome { get; set; }
        public int Idade { get; set; } = 10;

        public static int _maiorIdade = 18;

        public Pessoa()
        {
            _numeroDePessoas = _numeroDePessoas + 1;
            Idade = Idade + 1;
        }

        public void Apresentar()
        {
            Console.WriteLine("Olá eu sou " + Nome);
        }

        public static int CalcularIdade(int AnoNascimento)
        {
            return DateTime.Now.Year - AnoNascimento;
        }
    }
}
