using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa
    {
        //Propriedades
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int AnoNascimento { get; set; }
        public int idade { get; set; }

        //Construtor
        public Pessoa()
        {
            Nome = "Matheus";
            Sobrenome = "Placio";
            AnoNascimento = 0;
            idade = 0;
        } 
        public Pessoa(string Nome, string Sobrenome, int AnoNascimento)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.AnoNascimento = AnoNascimento;
            idade = Idade();
        }

        public Pessoa(string Nome, string Sobrenome)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.AnoNascimento = 2004;
            idade = Idade();
        }

        private int Idade()
        {
            return 2022 - AnoNascimento;
        }
    }
}
