using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Pessoa
    {
        public static IList<Pessoa> UsuariosDoSistema { get; set; } = new List<Pessoa>();
        public static int NumeroUsuarios => UsuariosDoSistema.Count;

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public static void PrintUsersDoSistema()
        {
            if (UsuariosDoSistema == null || UsuariosDoSistema.Count <= 0)
                throw new Exception("Sem usuários no sistema.");

            foreach (var user in UsuariosDoSistema)
            {
                Console.WriteLine($"{user.Nome}-{user.Sobrenome}-Nascimento: {user.DataDeNascimento.ToString("dd/MM/yyyy")}");
            }
        }

        public static void CriarESalvarPessoa(string nome, string sobrenome, DateTime dataDeNascimento)
        {
            var pessoa = new Pessoa
            {                
                Nome = nome,
                Sobrenome = sobrenome,
                //DataDeNascimento = dataDeNascimento,
            };

            if(dataDeNascimento <= DateTime.Now) pessoa.DataDeNascimento = dataDeNascimento;

            UsuariosDoSistema.Add(pessoa);
        }

        public static Pessoa CriarPessoa()//sobrecarga sem parâmetros
        {
            return new Pessoa
            {
                Nome = "Nome padrão"
            };
        }

        //Métodos simples
        public void Cumprimentar(string nome, int idade)
        {
            Console.WriteLine("Olá, meu nome é " + nome + " e tenho " + idade + " anos");
        }

        
    }
}
