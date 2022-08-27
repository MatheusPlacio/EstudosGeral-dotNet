namespace Console
{
    public class MetodosAprendizagem
    {
       public void Apresentacao()
        {
            System.Console.WriteLine("Olá, meu nome é Matheus e tenho 24 anos");
        }

        public void Apresentacao(string nome, int idade)
        {
            System.Console.WriteLine("Olá, meu nome é " + nome + " e tenho " + idade + " anos");
        }
      
        public string Apresentacao(string nome, string sobrenome)
        {
            string NomeCompleto = nome + sobrenome;
            return NomeCompleto;
        }
        
        public int MinhdaIdade()
        {
            return 24;
        }
    }
}
