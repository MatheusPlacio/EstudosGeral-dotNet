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
           
        }

      

    }
}
