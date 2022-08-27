using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class Metodo
    {

        public static void Excep()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            
            try
            {
                string res = "";
                for (int i = 0; i < 5; i++)
                {
                    res += list[i] + " ";

                }
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro !\n " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Operação finalizada.");
            }
        }
    }
}
