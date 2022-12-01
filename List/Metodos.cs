using System;
using System.Collections.Generic;
using System.Globalization;
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
            Console.WriteLine("A média é: " + m);
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

        public static IList<Pessoa> Pessoas(IList<Pessoa> pessoas)
        {
            foreach (var olhosCastanhos in pessoas)
            {
                if (olhosCastanhos.CorDoOlho == "Castanho")
                {
                    Console.WriteLine("Nome: " + olhosCastanhos.Nome);
                }
            }
            return pessoas;
        }

        public static IList<Pessoa> PessoasDeMaior(IList<Pessoa> pessoa)
        {
            foreach (var maiorIdade in pessoa)
            {
                if (maiorIdade.Idade >= 18)
                {
                    Console.WriteLine("Nomes: " + maiorIdade.Nome + " --- Idade: " + maiorIdade.Idade);
                }
            }
            return pessoa;
        }

        public void If()
        {
            var idade = 13;
            var maiorIdade = 18;

            if (maiorIdade < 18)
            {
                Console.WriteLine("Maior idade");
            }
            else if (idade > 18) {
                Console.WriteLine("Diferente");
            }
            else if (maiorIdade >= 18)
            {
                Console.WriteLine("Maior idade penal");
            }
        }

        public void Switch()
        {
            string valor = "Matheus";
            switch (valor)
            {
                case "Talio": Console.WriteLine("Não é o cara!");
                    break;
                case "Sandro":
                    Console.WriteLine("Não é o cara!");
                    break;
                case "Andre":
                    Console.WriteLine("Não é o cara!");
                    break;
                case "Matheus":
                    Console.WriteLine("É este!");
                    break;
                default: Console.WriteLine("Não encontrei");
                    break;
            }
        }

        public static void For() //FOR PERCORRE A LISTA DE ONDE VOCE DEFINIR
        {
            var divida = 0;
            for (int i = 0; i < 10; i++) // Nesse caso ele vai incrementar +5 durante 10 vezes
            {
                divida = divida + 5;
                Console.WriteLine(divida);
            }
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
        }

        public static void While() // O while ele incrementa o valor que vc decidir, ou tbm diminui
        {
            var valor = 10; // valor igual a 10
            while (valor < 100) // Enquanto o valor for menor ou igual 100
            {
                valor = valor + 5; // incrementa sempre +5
                Console.WriteLine(valor); // imprimi
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var valoor = 1350.00;
            while (valoor < 1500.00)
            {
                valoor = valoor + 100;
                Console.WriteLine(valoor);
            }
        }

        public static void Foreach(List<Pessoa> pessoa)   //FOREACH PERCORRE A LISTA INTEIRA DA PRIMEIRA À ULTIMA POSICAO
        {
            foreach (var pessoas in pessoa)
            {
                if (pessoas.Idade >= 18 && pessoas.CorDoOlho == "Verde" && pessoas.CorDePele == "Branca")
                {
                    Console.WriteLine($"Nome: {pessoas.Nome} -- Cor dos olhos: {pessoas.CorDoOlho} -- Raça: {pessoas.CorDePele}");
                }
            }           
        }

        public static void MesOrdenado()
        {
            IList<Mes> order = new List<Mes>();
            order.Add(new Mes { MesId = 12, Nome = "Dezembro" });
            order.Add(new Mes { MesId = 3, Nome = "Março" });
            order.Add(new Mes { MesId = 2, Nome = "Fevereiro" });
            order.Add(new Mes { MesId = 9, Nome = "Setembro" });
            order.Add(new Mes { MesId = 4, Nome = "Abril" });
            order.Add(new Mes { MesId = 6, Nome = "Junho" });
            order.Add(new Mes { MesId = 10, Nome = "Outubro" });
            order.Add(new Mes { MesId = 7, Nome = "Julho" });
            order.Add(new Mes { MesId = 1, Nome = "Janeiro" });
            order.Add(new Mes { MesId = 5, Nome = "Maio" });
            order.Add(new Mes { MesId = 8, Nome = "Agosto" });
            order.Add(new Mes { MesId = 11, Nome = "Novembro" });
            

            var meses = order.OrderBy(x => x.MesId);
            foreach (var mes in meses)
            {
                Console.WriteLine("Mes: " + mes.MesId + " -- Nome: " + mes.Nome);
            }
        }
    }
}
