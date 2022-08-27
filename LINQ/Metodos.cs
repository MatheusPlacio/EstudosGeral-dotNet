using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    public class Metodos
    {
        List<string> ListaNomes;
        List<int> ListaNumeros;
        Dictionary<string, double> ListaProdutos;
        Dictionary<string, string> ListaEstados;

        public Metodos()
        {
            #region Lista de Nomes
            ListaNomes = new List<string>();
            ListaNomes.Add("Matheus");
            ListaNomes.Add("Placio");
            ListaNomes.Add("Babo");
            ListaNomes.Add("Lucas");
            ListaNomes.Add("Marcos");
            ListaNomes.Add("Antonio");
            ListaNomes.Add("Souza");
            ListaNomes.Add("Silva");
            ListaNomes.Add("Ronaldo");
            ListaNomes.Add("Lukaku");
            ListaNomes.Add("Messi");
            ListaNomes.Add("Cristiano");
            ListaNomes.Add("Neymar");
            ListaNomes.Add("Henrique");
            ListaNomes.Add("Amanda");
            #endregion

            #region Lista de Numeros
            ListaNumeros = new List<int>();
            ListaNumeros.Add(7);
            ListaNumeros.Add(10);
            ListaNumeros.Add(0);
            ListaNumeros.Add(50);
            ListaNumeros.Add(04);
            ListaNumeros.Add(09);
            ListaNumeros.Add(11);
            ListaNumeros.Add(37);
            ListaNumeros.Add(61);
            ListaNumeros.Add(55);
            ListaNumeros.Add(24);
            ListaNumeros.Add(12);
            ListaNumeros.Add(63);
            ListaNumeros.Add(79);
            ListaNumeros.Add(81);
            ListaNumeros.Add(74);
            #endregion

            #region Lista de Produtos
            ListaProdutos = new Dictionary<string, double>();
            ListaProdutos.Add("Teclado USB", 49.95);
            ListaProdutos.Add("Teclado PS2", 45.95);
            ListaProdutos.Add("Teclado Gamer", 358.99);
            ListaProdutos.Add("Mouse", 29.5);
            ListaProdutos.Add("Monitor", 500.50);
            ListaProdutos.Add("Memória 16Gb", 375.75);
            ListaProdutos.Add("Memória 8Gb", 700.00);
            ListaProdutos.Add("Processador", 369.41);
            ListaProdutos.Add("Placa Mãe", 789.87);
            ListaProdutos.Add("Gabinete ATX", 49.95);
            #endregion

            #region Lista de Estados
            ListaEstados = new Dictionary<string, string>();
            ListaEstados.Add("Rio de Janeiro", "Brasil");
            ListaEstados.Add("São Paulo", "Brasil");
            ListaEstados.Add("New York", "Estados Unidos");
            ListaEstados.Add("Lisboa", "Portugal");
            ListaEstados.Add("Porto", "Portugal");
            ListaEstados.Add("Washington", "Estados Unidos");
            ListaEstados.Add("Ceara", "Brasil");
            ListaEstados.Add("Amsterdã", "Holanda");
            ListaEstados.Add("Madrid", "Espanha");
            #endregion
        }

        public void ListaNum() // Consulta
        { 
            var resultado = from num in ListaNumeros where num % 2 == 0 select num;

            foreach (var res in resultado)
            {
                Console.WriteLine(res);
            }
        }
         public void ListaDeNomes()
        {           
            var resultado = from nome in ListaNomes where nome.Contains("a") select nome;
            foreach (var n in resultado)
            {
                Console.WriteLine(n);
            }
        }

        public void PegarNumerosOrdenados()
        {     //orderby menor para o maior, e com o descending maior para o menor
            var resultado = from numeros in ListaNumeros
                            orderby numeros descending
                            select numeros;
            foreach (var n in resultado)
            {
                Console.WriteLine(n);
            }
        }

        public void Produtos()
        {
            var resultado = from produto in ListaProdutos 
                            orderby produto.Value descending
                            select produto;
            foreach (var n in resultado)
            {
                Console.WriteLine("Produto: "+ n.Key + " R$ " + n.Value);
            }
        }

        public void Estados()
        {
            var resultado = from estado in ListaEstados
                            group estado by estado.Value;

            foreach (var grupo in resultado)
            {
                Console.WriteLine(grupo.Key);
                foreach (var estado in grupo)
                {
                    Console.WriteLine("     " + estado.Key);
                }
            }
        }
    }
}