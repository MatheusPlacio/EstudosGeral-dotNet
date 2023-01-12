namespace DataAndHora
{
    public class Datahora
    {
        public static void Data()
        {            
            string diaAtual = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(diaAtual);

            var data = DateTime.Parse("21/11/2022").ToString("dd-MM-yyyy HH:mm:ss");
            Console.WriteLine(data);
        }

        public static void Hora()
        {
            string horaAtual = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(horaAtual);
        }
    }
}