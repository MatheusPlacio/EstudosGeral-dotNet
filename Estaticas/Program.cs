using Estaticas;

//MEMBROS ESTATICOS EU ACESSO DIRETAMENTO REFERENCIANDO A CLASSE E MEMBROS NAO ESTATICAS EU
//ACESSO SOMENTE ATRAVES DOS OBJETOS INSTACIADOS.

#region classe estatica
//Matematica.Taxa = 10;

//int valor1 = Matematica.Adicionar(200);
//int valor2 = Matematica.Diminuir(200);

//Console.WriteLine("Adicionar: " + valor1);
//Console.WriteLine("Diminuir: " +valor2);
#endregion

//Membro estatico \/, eu acesso diretamente referenciando a classe
Pessoa._maiorIdade = 21;

//Membro nao estatico onde eu crio um objeto instanciando a classe
Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();
Pessoa p3 = new Pessoa();
Pessoa p4 = new Pessoa();
Pessoa p5 = new Pessoa();
//p1.Nome = "Matheus";
//p1.Idade = Pessoa.CalcularIdade(1997);

//Console.WriteLine(p1.Nome);
//Console.WriteLine(p1.Idade);

Console.WriteLine($"Total de Pessoas -> {Pessoa._numeroDePessoas}");
Console.WriteLine($"Idade de p1 -> {p1.Idade}");

Console.WriteLine($"Minha idade -> {Pessoa.CalcularIdade(1998)}");


String.IsNullOrEmpty("asdasd");

Console.ReadLine();