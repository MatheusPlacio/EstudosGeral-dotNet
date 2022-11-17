namespace Fibonacci
{
    public class Metodo
    {
        public void Fibo()
        {
            int n1 = 1;
            int n2 = 0;

            for (int i = 0; i <= 10; i++)
            {
                int soma = n1 + n2;
                n1 = n2;
                n2 = soma;
            }
        }

        public void media()
        {
            List<int> Joao = new List<int>();
            Joao.Add(20);
            Joao.Add(8);
            var j = Joao.Average();
            Console.WriteLine("Joao: " + j);
            Console.WriteLine("============");

            List<int> Marcos = new List<int>();
            Marcos.Add(30);
            Marcos.Add(18);
            var m = Marcos.Average();
            Console.WriteLine("Marcos: " + m);
            Console.WriteLine("============");

            List<int> Jasiel = new List<int>();
            Jasiel.Add(40);
            Jasiel.Add(24);
            var ja = Jasiel.Average();
            Console.WriteLine("Jasiel: " + ja);
            Console.WriteLine("============");
        }

        // Criar um método que recebe uma lista de pessoas e retorna as pessoas no SPC

       
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
                if (pessoa.NomeSPC && pessoa.DataSPC >= new DateTime(2000, 01, 01))
                {
                    pessoasNoSPC.Add(pessoa);
                }
            }

            //FOR PERCORRE A LISTA DE ONDE VOCE DEFINIR
            for (int i = 0; i < pessoas.Count; i++)
            {
                if (pessoas[i].NomeSPC && pessoas[i].DataSPC >= new DateTime(2000, 01, 01))
                {
                    pessoasNoSPC.Add(pessoas[i]);
                }
            }

            return pessoasNoSPC;
        }

        /// <summary>
        /// Quando utilizar: quando a quantidade de itens de uma lista for desconhecida
        /// </summary>
        public static void While()
        { 
            var divida1 = 1000;
            while (divida1 != 0 ) // ficar no loop enquanto a divida existir
            {
                divida1 = divida1 - 1;
                //divida1--;

                Console.WriteLine("Valor da divida: " + divida1);
            }
        }
        /// <summary>
        /// Quando utilizar: quando a quantidade de uma lista for conhecida e vc precisa acessar um item de posição especifica
        /// </summary>
        public static void For()
        {
            for (int i = 1000; i != 0; i++)
            {
                i = i - 1;
                //divida1--;

                Console.WriteLine("Valor da divida: " + i);

            }
        }

        /// <summary>
        /// Quando utilizar: quando a quantidade de uma lista for conhecida
        /// </summary>
        public static void Foreach()
        {

        }
    }
}
