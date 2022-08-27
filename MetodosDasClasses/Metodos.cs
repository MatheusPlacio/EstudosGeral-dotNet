using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    public class Metodos
    {
        //Métodos simples sem parâmetros
        public void Apresentação()
        {
            Console.WriteLine("Olá, meu nome é Matheus e tenho 24 anos");
        }

        //Métodos com Parâmetros
        public void Apresentacao(string nome, int idade)
        {
            Console.WriteLine("Olá, meu nome é " + nome + " e tenho " + idade + " anos");
        }

        public void Calculadora()
        {
        Inicio:
            Console.WriteLine("Digite o primeiro número");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digita o segundo número");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação desejada (+ - * /): ");
            char c = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (c)
            {
                default:
                    Console.WriteLine("Erro, opção inválida");
                    break;

                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;

                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;

                case 'x':
                case 'X':
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplacação é: " + resultado);
                    break;

                case '/':
                case ':':

                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0.");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                    }
                    break;

            }

            Console.WriteLine("Continuar calculando (s / n)? ");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }
        }

        // Passagem de parâmetros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é: " + valor);
        }

        // Passagem de parâmetros por referência
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por referência) é: " + valor);
        }
            
        // Métodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            string nomeCompleto = nome + " " + sobrenome;
            return nomeCompleto;
        }

        public int CodigoChar(char caractere)
        {
            int codigo = (int)caractere;
            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }

        // Sobrecarga de métodos
        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá" + nome);
        }
        public void Cumprimentar(string nome, int hora)
        {
            if (hora < 12)
            {
                Console.WriteLine("Bom dia " + nome);
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde " + nome);
            }
            else if (hora >= 18)
            {
                Console.WriteLine("Boa noite "+ nome);
            }
        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool Comparar(string num1, string num2)
        {
            return num1 == num2;
        }

    }
}
