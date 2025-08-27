using ExemploFundamentos.Commom.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Fa";
pessoa1.Idade = 20;
pessoa1.Apresentar();

/*
// o using ajuda a dar o caminho de onde esta a classe
using Back_end_com_.NET_e_IA.Models;
Pessoa pessoa1 = new Pessoa();
pessoa1.Idade = 30;
//aqui eu coloco os respecivos dados
pessoa1.Nome = "Fabi";
pessoa1.Apresentar();
*/

/*
int a = 10;
int b = 20;
int c = a + b;
// c = c + 5 é igual a c += 5
c += 5;
Console.WriteLine(c);
*/

// conversão de numeros
// CAST - CASTING, converte um tipo para outro tipo
// int a = Convert.ToInt32("5"); convert aceita null e parse não
// int a = int.Parse("5");
// Console.WriteLine(a);

/*
// conversão de texto usa o ToString
int inteiro = 5;
string a = inteiro.ToString();
Console.WriteLine(a);
*/

/*
// um inteiro cabe no double, logo não precisa de conversão, se for ao contrario o sistema reclamará
int a = 5;
double b = a;
Console.WriteLine(b);
*/

/*
// um inteiro cabe no long, logo não precisa de conversão, se for ao contrario o sistema reclamará
int a = 5;
long b = a;
Console.WriteLine(b);
*/

/*
// conversão
int a = int.MaxValue;
long b = a;
Console.WriteLine(b);
*/

/*
//ordem dos operadores
//primeiro parentesis
//expoente
//divisão ou multiplicação 
//adição e subtração
// double a = 4 / 2 + 2; //resultado 4
double a = 4 / (2 + 2); //resultado 1 
Console.WriteLine(a);
*/

/*
// tryparse ja espera que de erro
string a = "15-";
// int b = 0;
//int.TryParse(a, out b); // como se fosse uma cascata, aqui eu indico que eu tento converter o a, mas tenho ciencia de que ele pode não ser um numero,nesse caso não conseguiu, por isso não exibe a e o valor de saída será o b
int.TryParse(a, out int b); //aqui procede da mesma forma, porem ja to declarando a variavel aqui dentro, que por default int é 0
Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso");
*/

/*

//OPERAÇÃO CONDICIONAL 
//EXEMPLO 1


int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda realizada");
}
else 
{
    Console.WriteLine("Desculpe, não temos a qtdade desejada em estoque");
}
*/

/*
//EXEMPLO 2
int quantidadeEmEstoque = 0;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra; //uma variavel booleana que vai representar ou verdadeiro ou falso, neste exemplo imprime TRUE

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe, não temos a qtdade desejada em estoque");
}

*/

/*
//o scanner no java é o console.readline no C# onde o usuario inputa um valor
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine(" Não é uma Vogal");
        break;
}
*/

/*
//OR
bool ehMaiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada!");
}
else
{
    Console.WriteLine("Entrada não liberada");
}
*/

/*
//AND
bool possuiPresencaMinima = true;
double media = 6.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}
*/

/*
//NOT - nega um valor boleano, representado pelo ponto de exclamação, vc inverte o valor dele
bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar um outro dia");
}

*/

// using Back_end_com_.NET_e_IA.Models;
// primeira coisa eu preciso instanciar a classe calculadora
// pra isso tenho que criar uma variavel do tipo calculadora
// Calculadora calc = new Calculadora();

/*
// agora usa calc, e aparecerá os 4 metodos
//lembrando que vc inputou que os metodos devem ter 2 parametros
calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);
calc.Potencia(3, 3);

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);


int numeroIncremento = 10;

Console.WriteLine(numeroIncremento);
Console.WriteLine("Incrementando o 10");
//numero = numero + 1; é igual a numero++
numeroIncremento++;
Console.WriteLine(numeroIncremento);

int numeroDecremento = 20;
Console.WriteLine(numeroDecremento);
Console.WriteLine("Decrementando o 20");
numeroDecremento--;
Console.WriteLine(numeroDecremento);

calc.RaizQuadrada(9);


// laço de repetição

// FOR, recebe 3 blocos, a declaração da variável, a condição, e um incremento
// WHILE, mais simples que o for, pois, só recebe 1 condição, ATENÇÃO vc precisa colocar alguma quebra, senão o while ficará em looping
// DO WHILE, a verificação é no final do código

/*
// FOR ele repete um pedaço de codigo
int numero = 10;
// inicio, no meio fica onde eu quero que seja false, e por ultimo a ação
for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}



// WHILE, recebe apenas a condição
int numero = 5;
int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{contador + 1} Execução: {numero} * {contador} = {numero * contador}");
    contador++;
}


// aqui não duas variaveis declaradas, soma e numero e ambas são int
int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número (0 para)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while (numero != 0); 
//ate o while ser true ele executa o do
Console.WriteLine($"Total da soma dos números digitados é: {soma}");


string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    //Console.Clear();
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou"); 
*/