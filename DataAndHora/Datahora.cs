namespace DataAndHora
{
    public class Datahora
    {
        public static void Data()
        {
            //string diaAtual = $"{DateTime.Now:yyyy-MM-dd}";
            string diaAtual = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(diaAtual);

            var data = DateTime.Parse("10/09/2018").ToString("dd-MM-yyyy");
            Console.WriteLine(data);
        }

        public static void Hora()
        {
            string horaAtual = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(horaAtual);
        }
    }
}