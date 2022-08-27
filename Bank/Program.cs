using Bank;

Pessoa.CriarESalvarPessoa("Placio", "Bobo", DateTime.Now);
Pessoa.CriarESalvarPessoa("Placio2", "Bobo2", DateTime.Now);
Pessoa.CriarESalvarPessoa("Placio3", "Bobo333", DateTime.Now);
Pessoa.CriarESalvarPessoa("Placio4", "Bobo44444", DateTime.Now);

for (int i = 1; i <= 114; i++)
{
    Pessoa.CriarESalvarPessoa($"User{i}", $"MulinhaMaster{i}", DateTime.Now);
}

Console.WriteLine($"Número de usuários -> {Pessoa.NumeroUsuarios}");
Pessoa.PrintUsersDoSistema();

Console.ReadLine();
