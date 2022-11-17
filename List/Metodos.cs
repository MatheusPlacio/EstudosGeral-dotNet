using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Metodos
    {
       //public static void Nomes()
       // {
       //     string[] nomes = new string[3];
       //     nomes[0] = "Matheus";
       //     nomes[1] = "Placio";
       //     nomes[2] = "Babo";

       //     foreach (var nome in nomes)
       //     {
       //         Console.WriteLine(nome);
       //     }
       // }

       public static void Carros()
        {
            List<string> carros = new List<string>();
            carros.Add("Honda fit");
            carros.Add("Sandero");
            carros.Add("Etios");
            carros.Add("Gol Quadrado");
            carros.Add("Agile");
            carros.Add("Astra");            
            carros.Add("Vectra");

            if (carros.Count > 3) Console.WriteLine("Lista de carros");
            Console.WriteLine();
            foreach (var carro in carros)
            {
               Console.WriteLine(carro);
            }

            Console.WriteLine("=====================");
            List<int> media = new List<int>();
            media.Add(290);
            media.Add(662);

            var m = media.Average();
            Console.WriteLine("A média é: "+ m);
        }

        public static IList<Pessoa> PessoasNoSPC(IList<Pessoa> pessoas)
        {
            //criar uma lista de pessoas vazia
            //verificar se as pessoas recebidas estao no SPC
            //Armazenar as pessoas do SPC na nova Lista
            //retornar lista

            List<Pessoa> pessoasNoSPC = new List<Pessoa>();

            //Posicao na Lista           0        1        2        3        4      ...
            //Lista 'listaPessoas1' { Pessoa1, Pessoa2, Pessoa3, Pessoa4, Pessoa5 } ...
            //listaPessoas1.Count == 5

            //FOREACH PERCORRE DA PRIMEIRA À ULTIMA POSICAO
            foreach (var pessoa in pessoas)
            {
                if (pessoa.NomeSPC)
                {
                    pessoasNoSPC.Add(pessoa);
                }
            }

            //FOR PERCORRE A LISTA DE ONDE VOCE DEFINIR
            //for (int i = 0; i < pessoas.Count; i++)
            //{
            //    if (pessoas[i].NomeSPC && pessoas[i].DataSPC >= new DateTime(2000, 01, 01))
            //    {
            //        pessoasNoSPC.Add(pessoas[i]);
            //    }
            //}

            return pessoasNoSPC;
        }
    }
}
