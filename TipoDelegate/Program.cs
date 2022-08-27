using TipoDelegate;
class program
{
    //O delegate consegue rodar todos os métodos ao mesmo tempo
     delegate void Operacao(int n1, int n2);

    static void Main(string[] args)
    {
      Matematica m = new Matematica();

        Operacao conta = null;

        conta += m.Somar;
        conta += m.Subtrair;
        conta += m.Multiplicar;
        conta += m.Dividir;

        conta(10, 2);


        Console.ReadLine();

    }

}