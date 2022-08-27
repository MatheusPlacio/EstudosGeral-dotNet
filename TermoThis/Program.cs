using TermoThis;

Acessar a = new Acessar();

if (a.Login("abc123")){
    Console.WriteLine("Bem-vindo");
}
else
{
    Console.WriteLine("Acesso negado");
}
