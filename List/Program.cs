using List;

List<Pessoa> pessoasDB = new List<Pessoa>();
pessoasDB.Add(new Pessoa { Nome = "Matheus", NomeSPC = false });
pessoasDB.Add(new Pessoa { Nome = "Ludke", NomeSPC = true });
pessoasDB.Add(new Pessoa { Nome = "Maikon", NomeSPC = true });
pessoasDB.Add(new Pessoa { Nome = "Mulinha", NomeSPC = true });
pessoasDB.Add(new Pessoa { Nome = "Luana", NomeSPC = false });
pessoasDB.Add(new Pessoa { Nome = "Mr Mula", NomeSPC = false });
pessoasDB.Add(new Pessoa { Nome = "Neymar", NomeSPC = true });
pessoasDB.Add(new Pessoa { Nome = "Judas", NomeSPC = false });


var retorno = Metodos.PessoasNoSPC(pessoasDB);

foreach (var pessoa in retorno)
{
    Console.WriteLine($"Nome: {pessoa.Nome}");
}


Console.ReadLine();