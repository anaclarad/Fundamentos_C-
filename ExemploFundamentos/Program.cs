using ExemplosFundamentos.Common.Models;


// Aqui eu já tenho minha pessoa construída, então pode-se fazer alterações nela e utilização
// Ao declarar variável sempre em camel case

// Pessoa p = new Pessoa();
// p.Nome = "Ana";
// p.Idade = 22;
// p.Apresentar();


// p.Nome = "Ana Clara";
// p.Idade = 22;

// p.Apresentar();


// string apresentacao = "Olá seja bem vindo";

// int quantidade =1;
// double altura = 1.80;

// // para tratativas de dinheiro sempre usar o decimal
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine($"Quantidade é {quantidade}");
// Console.WriteLine("Valor de altura é" + altura);
// Console.WriteLine("Valor de preco é" + preco);
// Console.WriteLine("Valor de condicao é" + condicao);

//tipo datetime-- pode ser explorado na documentação
// com o método Add posso adicionar dias, horas, segundos e etc
// DateTime dataAtual = DateTime.Now;

// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

// DateTime dataAtualMaisCinco = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtualMaisCinco);

// atribuição

// int  a = 20;
// int b = 30;

// int c = a + b;

// // isto abaixo é igual a "c =+ 5"
// c = c + 5;

// Console.WriteLine(c);

//convertendo tipos de variáveis- Muitas vezes recebemos uma variável como um tipo específico mas precisamos converter e esse proceso se chama casting

// diferença do convert e parse. O convert aceita valores nulos, ou seja, se receber um nulo ele irá fazer sua representação como 0. Já o parse vai fazer a quebra do progrma.
// int a = Convert.ToInt32("5");

// int b = int.Parse("10");
//Para converter para String temos um tratamento especial pois não se usa nem o converte nem o parse mas sim o  o ToString();

// int inteiro = 15;
// string teste = inteiro.ToString();

//Casting implicito -- é possível ter essa conversão "automática" se o elemento no qual desejo converter seja para um tipo com tamanho supeior ao atual, nunca com tamnho inferior, pois se for, terá que ser convertido manualmente.

// este é um exemplo válido
// int a = 5;
// double b = a;


// estrtura if no c#endregion

// if (condição){O que será executado se condição satisfeita}; else ou else if {Condição que será executada};

//switch case --- usado quando tem muitos caminhos e condições possíveis



// Console.WriteLine("Digite uma letra:");

// string letra = Console.ReadLine();

// switch (letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é vogal");
//         break;
// }


//Operadores lógicos
//operador OR representado por ||
//Operador And é representado por &&
//Operador Not representado por ! e nega uma variável ou condição

/// Operadores aritméticos 
/// temos o Roun que faz um arrendondamento com base na quantidade de casas que escolher = ex: Math.Round(Number, casas decimais);

// Calculadora calc = new Calculadora();

// calc.Somar(10,20);
// calc.Subtrair(10,5);
// calc.Multiplicar(10,2);
// calc.Dividir(10,2);
// calc.Potenvia(3,3);

// incremente e decremento

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando a 10");

// numero++; //para decremento basta colocar --

// Console.WriteLine(numero);

//Raiz quadrada  representada por Math.Sqrt();

//Estrutura de repetição 

// int numero = 5;

// for (int contador = 0; contador <= 10;contador ++){
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }
//  int numero = 5;
//  int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 5){
//         break;
//     }
// }

// string opcao;

// while(true){
//         Console.WriteLine("Digite a sua opção:");
//         Console.WriteLine("1- Cadastrar cliente:");
//         Console.WriteLine("2- Buscar cliente:");
//         Console.WriteLine("3- Apagar cliente:");
//         Console.WriteLine("4- Encerrar:");

//         opcao = Console.ReadLine();

//         switch(opcao)
//         {
//             case "1":
//                 Console.WriteLine("Cadastro de cliente");
//                 break;
//             case "2":
//                 Console.WriteLine("Busca de cliente");
//                 break;
//             case "3":
//                 Console.WriteLine("Exclusão de cliente");
//                 break;
//             case "4":
//                 Console.WriteLine("Programa encerrado");
//                 Enviroment.Exit(0);
//                 break;
//             default:
//                 Console.WriteLine("Opção Inválida");

//         }

// }

///array 
// int[] array = new int[3];

// array[0] = 5;
// array[1] = 4;
// array[2] = 3;

// //percorrenoo array coom o for

// for (int contador = 0; contador <= array.Length;contador ++){
//     Console.WriteLine($"Número é {array[contador]}");
// }

// //percorrendo com o foreach

// foreach ( int valor in array)
// {
//     Console.WriteLine($"O valor é `{valor}");
// }

// //aumentar o tamanho do array - o array nasce e morre com a mesma capacidade. O rescize copia o array e cria um novo com uma nova dimensão

// // Array.Resize(ref array,array.Length*2);


// //fazendo exatamente o que o rescize faz mas de maneira mais extensa
// int[] arrayDobrado = new int [array.Length*2];
// Array.Copy(array,arrayDobrado,array.Length);

// Listas - posso colocar o nome da lista.metodoutilizado e assim conseguir chamar o método para usar o que preciso

List<string> listastring = new List<string>();

