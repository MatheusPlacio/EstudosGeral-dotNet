
#region Prioridades na equação

////Semppre vai resolver priemiro o que está em parentes, e após a multiplicação ou a divisão o que estiver na esquerda.
//int num = 100;
//int num1 = 10;
//double num2 = 5;

//double res = (num + num1) * (num2 / 2);

//Console.WriteLine(res);


#endregion


#region Operadores de atribuições

//int MaisIgual = 10;
//MaisIgual += 20;

//Console.WriteLine(MaisIgual);
#endregion

#region graus celcius
//double c, f, k;

//Console.WriteLine("Conversor de Temperaturas");
//Console.Write("Insira a temperatura em Celcius: ");
//c = double.Parse(Console.ReadLine());
//Console.WriteLine(" --------------------------------- ");

//f = (c * 9 / 5) + 32;

//k = c + 273.15;

//Console.WriteLine(c + " graus celcius = " + f + " graus fahrenheit");
//Console.WriteLine(c + " graus celcius = " + k + " graus kelvin");
//Console.WriteLine(" --------------------------------- ");

//Console.ReadLine();
#endregion

#region Vetores
//int[] numeros = new int[5]; //vetor do tipo int, depois instaciamos com a quantidade que no caso é 5

//numeros[0] = 10;  //atribuimos o valor
//numeros[1] = 20;
//numeros[2] = 30;
//numeros[3] = 40;
//numeros[4] = 50;

//string[] nomes =     //Jeito mais fácil de criar o vetor
//    { "Matheus",
//      "Marcos",
//      "Manu"
//    };



//Console.WriteLine(numeros[2]);
//Console.WriteLine(nomes[0]);
#endregion

#region CalcularIMC

//Console.Write("Informa o peso em kg: ");
//double peso = double.Parse(Console.ReadLine());

//Console.Write("Informa a altura: ");
//double altura = double.Parse(Console.ReadLine());

//double ValorIMC = peso / (altura * altura);


//if(ValorIMC < 20)
//{
//    Console.WriteLine("IMC = " + ValorIMC + " : Você está abaixo do peso");
//}

//else if(ValorIMC >= 20 && ValorIMC <= 24)
//{
//    Console.WriteLine("IMC = " + ValorIMC + " : Seu IMC está normal");
//}
//else if(ValorIMC >= 25 && ValorIMC <= 29)
//{
//    Console.WriteLine("IMC = " + ValorIMC + " : Você está acima do peso");
//}
//else if (ValorIMC >= 30 && ValorIMC <= 34)
//{
//    Console.WriteLine("IMC = " + ValorIMC + " : Você está obeso");
//}
//else
//{
//    Console.WriteLine("IMC = " + ValorIMC + " : Você está muito obeso");
//}
#endregion

#region IMC
//Console.WriteLine("Digite o seu peso em Kg: ");
//double Peso = double.Parse(Console.ReadLine());

//Console.WriteLine("Digite sua altura: ");
//double Altura = double.Parse(Console.ReadLine());

//double CalculoIMC = Peso / (Altura * Altura);

//if (CalculoIMC < 18.5) {
//    Console.WriteLine("Vc está abaixo do peso");
//}

//else if(CalculoIMC >= 18.5 && CalculoIMC <= 24.9){
//    Console.WriteLine("Seu peso está normal");
//}
//else if (CalculoIMC >= 25 && CalculoIMC <= 29.9)
//{
//    Console.WriteLine("Vc está acima do peso");
//}
//else if(CalculoIMC > 30)
//{
//    Console.WriteLine("Vc está obeso");
//}
//else
//{
//    Console.WriteLine("Vc está muito obeso");

//}
#endregion

#region Switch Case
//Console.WriteLine("Escolha uma das criptmoedas abaixo");
//Console.WriteLine("1- BTC");
//Console.WriteLine("2- ETH");
//Console.WriteLine("3- SOL");
//Console.WriteLine("0-Sair");

//int criptomoeda = int.Parse(Console.ReadLine());

//switch (criptomoeda)
//{
//    case 1: 
//        Console.WriteLine("1- Maior cripto do mundo");
//        break;
//    case 2:
//        Console.WriteLine("2- Segunda maior cripto do mundo");
//        break;
//    case 3:
//        Console.WriteLine("3- Terceira maior cripto do mundo");
//        break;

//        default:
//        Console.WriteLine("Opção inválida");
//        break;

//}


#endregion

#region Goto com switch case
//Inicio:
//Console.WriteLine("Escolha uma opção: ");
//int op = int.Parse(Console.ReadLine());
//int valor = 0;

//switch (op)
//{
//    default:
//        goto Inicio;
//        break;
//    case 1:
//        valor += 100;
//        break;
//    case 2:
//        valor += 50;
//        goto case 1;
//}

//Console.WriteLine("Valor final: " + valor);

#endregion

#region Calculadora
//Inicio:
//Console.Clear();

//Console.Write("Digita o primeiro número: ");
//double num1 = double.Parse(Console.ReadLine());

//Console.Write("Digite o segundo número: ");
//double num2 = double.Parse(Console.ReadLine());

//Console.Write("Escolha a operação (+ - x /): ");
//char op = char.Parse(Console.ReadLine());

//double resultado = 0;

//switch (op)
//{
//    default:
//        Console.WriteLine("Erro, opção inválida");
//        break;

//    case '+':
//        resultado = num1 + num2;
//        Console.WriteLine("O resultado da soma é: " + resultado);
//        break;

//    case '-':
//        resultado = num1 - num2;
//        Console.WriteLine("O resultado da subtração é: " + resultado);
//        break;

//    case 'x':
//    case 'X':
//    case '*':
//        resultado = num1 * num2;
//        Console.WriteLine("O resultado da multiplacação é: " + resultado);
//        break;

//    case '/':
//    case ':':

//        if (num2 == 0)
//        {
//            Console.WriteLine("Não é possível dividir por 0.");
//        }
//        else
//        {
//            resultado = num1 / num2;
//            Console.WriteLine("O resultado da divisão é: " + resultado);
//        }
//        break;

//}

//Console.WriteLine("Continuar calculando (s / n)? ");
//string opcao = Console.ReadLine();

//if (opcao == "s" || opcao == "S")
//{
//    goto Inicio;
//}


#endregion

#region While

//int valor = 0;

//while (valor < 10)
//{
//    Console.WriteLine("O valor é "+ valor);
//    valor++;

//}



#endregion

#region For
//for (int i = 1750; i <= 43260; i++)
//{
//    string numString = i.ToString();
//    if (numString.IndexOf("2") != -1 && numString.IndexOf("7") == -1)
//    {
//        Console.Write(i + " ");
//    }
//}

#endregion

#region foreach

//string[] nomes = { "Matheus", "Lucas", "João", "Marcos" };

//foreach (var nome in nomes)
//{
//    Console.WriteLine("Nome: " + nome);

//}


#endregion

#region Fibonacci
//int a = 0;
//int b = 1;
//int c = 0;

//Console.Write("Quantos valores: ");
//int valores = int.Parse(Console.ReadLine());

//Console.WriteLine("Sequência de Fibonacci com " + valores + " valores ");

//for (int i = 0; i < valores; i++)
//{
//    if (i < valores - 1)
//    {
//        Console.Write(a + ", ");
//    }
//    else
//    {
//        Console.Write(a);
//    }

//    c = a + b;
//    a = b;
//    b = c;
//}


#endregion


using Console;
MetodosAprendizagem m = new MetodosAprendizagem();
m.Apresentacao();
m.Apresentacao("Matheus", 24);
string NomeCompleto = m.Apresentacao("Matheus", " Placio");


System.Console.WriteLine(NomeCompleto);

