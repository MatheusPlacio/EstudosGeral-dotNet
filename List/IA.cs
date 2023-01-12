using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class IA
    {
        public static Dictionary<string, List<string>> GetBrazilCities()
        {
            var brazilCities = new Dictionary<string, List<string>>();

            brazilCities.Add("Acre", new List<string> { "Rio Branco" });
            brazilCities.Add("Alagoas", new List<string> { "Maceió" });
            brazilCities.Add("Amapá", new List<string> { "Macapá" });
            brazilCities.Add("Amazonas", new List<string> { "Manaus" });
            brazilCities.Add("Bahia", new List<string> { "Salvador" });
            brazilCities.Add("Ceará", new List<string> { "Fortaleza" });
            brazilCities.Add("Distrito Federal", new List<string> { "Brasília" });
            brazilCities.Add("Espírito Santo", new List<string> { "Vitória" });
            brazilCities.Add("Goiás", new List<string> { "Goiânia" });
            brazilCities.Add("Maranhão", new List<string> { "São Luís" });
            brazilCities.Add("Mato Grosso", new List<string> { "Cuiabá" });
            brazilCities.Add("Mato Grosso do Sul", new List<string> { "Campo Grande" });
            brazilCities.Add("Minas Gerais", new List<string> { "Belo Horizonte" });
            brazilCities.Add("Pará", new List<string> { "Belém" });
            brazilCities.Add("Paraíba", new List<string> { "João Pessoa" });
            brazilCities.Add("Paraná", new List<string> { "Curitiba" });
            brazilCities.Add("Pernambuco", new List<string> { "Recife" });
            brazilCities.Add("Piauí", new List<string> { "Teresina" });
            brazilCities.Add("Rio de Janeiro", new List<string> { "Rio de Janeiro" });
            brazilCities.Add("Rio Grande do Norte", new List<string> { "Natal" });
            brazilCities.Add("Rio Grande do Sul", new List<string> { "Porto Alegre" });
            brazilCities.Add("Rondônia", new List<string> { "Porto Velho" });
            brazilCities.Add("Roraima", new List<string> { "Boa Vista" });
            brazilCities.Add("Santa Catarina", new List<string> { "Florianópolis" });
            brazilCities.Add("São Paulo", new List<string> { "São Paulo" });
            brazilCities.Add("Sergipe", new List<string> { "Aracaju" }); ;

            foreach (var estado in brazilCities)
            {
                Console.WriteLine(estado.Key + ":");
                foreach (var cidade in estado.Value)
                {
                    Console.WriteLine("  " + cidade);
                }
                Console.WriteLine();
            }

            return brazilCities;
        }

        public static void Forca()
        {
            // Palavra a ser adivinhada
            string word = "palavra";

            // Número de tentativas permitidas
            int tries = 5;

            // Lista de letras já adivinhadas
            List<char> guessedLetters = new List<char>();

            // Loop do jogo
            while (tries > 0)
            {
                // Mostra a palavra atual com as letras já adivinhadas e os espaços para as não adivinhadas
                for (int i = 0; i < word.Length; i++)
                {
                    if (guessedLetters.Contains(word[i]))
                    {
                        Console.Write(word[i] + " ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine();

                // Solicita uma nova tentativa
                Console.Write("Digite uma letra: ");
                char guess = char.Parse(Console.ReadLine());

                // Verifica se a letra já foi adivinhada
                if (guessedLetters.Contains(guess))
                {
                    Console.WriteLine("Você já adivinhou essa letra!");
                    continue;
                }

                // Adiciona a letra à lista de letras já adivinhadas
                guessedLetters.Add(guess);

                // Verifica se a letra está na palavra
                if (word.Contains(guess))
                {
                    Console.WriteLine("Acertou!");

                    // Verifica se a palavra foi completamente adivinhada
                    bool wordGuessed = true;
                    foreach (char c in word)
                    {
                        if (!guessedLetters.Contains(c))
                        {
                            wordGuessed = false;
                            break;
                        }
                    }

                    if (wordGuessed)
                    {
                        Console.WriteLine("Você adivinhou a palavra! Parabéns!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Errou!");
                    tries--;
                }
            }

            // Verifica se o jogador perdeu o jogo
            if (tries == 0)
            {
                Console.WriteLine("Você perdeu o jogo! A palavra era: " + word);
            }
        }
    }
}


