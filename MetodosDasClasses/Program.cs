using MetodosDasClasses;

Metodos m = new Metodos();
//m.Apresentação();
//m.Apresentacao("Matheus", 24);

//int valor1 = 100;
//int valor2 = 100;
//m.AumentarValor(valor1);
//m.AumentarRef(ref valor2);

//Console.WriteLine("Valor 1: " + valor1);
//Console.WriteLine("Valor 2: " + valor2);

//string nomeCompleto = m.MontaNome("Matheus", "Placio");
//int codigoChar = m.CodigoChar('a');
//double pi = m.ValorPI();
m.Cumprimentar("Matheus", 18);

bool x = m.Comparar(100, 50 * 2);
bool M = m.Comparar("Matheus", "matheus");


Console.WriteLine(x);
Console.WriteLine(M);
//Console.WriteLine(nomeCompleto);
//Console.WriteLine(codigoChar);
//Console.WriteLine(pi);


Console.ReadLine();