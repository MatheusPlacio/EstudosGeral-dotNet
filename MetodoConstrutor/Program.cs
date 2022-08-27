using MetodoConstrutor;

Pessoa p1 = new Pessoa();

Console.WriteLine(p1.Nome);
Console.WriteLine(p1.Sobrenome);
Console.WriteLine(p1.AnoNascimento);
Console.WriteLine(p1.idade);

Console.WriteLine();

Pessoa p2 = new Pessoa("Gabriel", "Artigas", 1985);
{
    Console.WriteLine(p2.Nome);
    Console.WriteLine(p2.Sobrenome);
    Console.WriteLine(p2.AnoNascimento);
    Console.WriteLine(p2.idade);
}

Console.WriteLine();

Pessoa p3 = new Pessoa("Lucas", "Silva");
{
    Console.WriteLine(p3.Nome);
    Console.WriteLine(p3.Sobrenome);
    Console.WriteLine(p3.AnoNascimento);
    Console.WriteLine(p3.idade);
}

Console.ReadLine();