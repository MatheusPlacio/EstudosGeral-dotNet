using Encapsular;

Conta c = new Conta();
c.Cliente = "Matheus";
c.Saldo = 100;

//===Operação de deposito====
double valor = 100;
c.Depositar(valor);

//===Operação de Saque====
c.Sacar(50);


//Resultado Saldo atual
Console.WriteLine("Cliente: " + c.Cliente);
Console.WriteLine("Saldo: " + c.Saldo);

Console.ReadLine();