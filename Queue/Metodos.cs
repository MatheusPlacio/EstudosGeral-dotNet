using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Metodos
    {
        public static void Filas()
        {
            Console.Clear();

            Queue<string> fila = new();
            fila.Enqueue("Matheus");
            fila.Enqueue("Danny");
            fila.Enqueue("Sérgio");
            fila.Enqueue("Arthur");

            Console.WriteLine(fila.Count.ToString());

            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }
                       
            Console.WriteLine("Primeiro da fila: " + fila.Peek()); // O Peek ele mostra o 1° da fila, mas não o remove
            Console.WriteLine(fila.Count.ToString());              // O First também serve


            Console.WriteLine("Primeiro da fila: " + fila.Dequeue()); // O Dequeue ele mostra o 1° da fila e o remove
            Console.WriteLine(fila.Count.ToString());

           
            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }
        }
    }
}
