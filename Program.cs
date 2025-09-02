//Variáveis
//C# - linguagem FORTEMENTE tipada
//tipos de dados: string, int, float, double, bool
// tipoDeDado nomeDaVariavel = valorAtribuido
string nome = "Laura"; //Criando e atribuindo a variável
int idade = 18; //Criei e atribui a variável

Console.WriteLine("O nome do usuário é: " + nome); //imprimi a variavel COM CONCATENÇÃO
//!Com o @ é possível quebrar as linhas
Console.WriteLine(@$"A idade do usuário é: 
{idade}"); //imprimi a variavel com a interpolação

// var -> A palavra-chave var no C# é usada para declaração de variáveis com tipo implícito, onde o compilador determina o tipo da variável com base no valor da inicialização. Isso pode tornar o código mais conciso, especialmente com tipos longos ou anônimos, e pode facilitar a refatoração, pois alterações no tipo de retorno de um método não exigem alterações no código que usa essa variável. No entanto, o uso excessivo de var pode reduzir a legibilidade do código, especialmente quando o tipo não é óbvio, e pode dificultar a detecção de erros. 

var nomeDois = "Caio";
var idadeDois = 17;
var verificacao = true;
Console.WriteLine(nomeDois);
Console.WriteLine(idadeDois);
Console.WriteLine(verificacao);

//constantes -> valores fixos
const int qtdDeMeses = 12;
Console.WriteLine(qtdDeMeses);

//Operadores aritméticos:
// +
// -
// * - multiplicação
// /
// % - resto/mod
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-----------OPERADORES ARITMÉTICOS--------------");
int anoAtual = 2025;
int anoNascimento = 2008;

int idade3 = anoAtual - anoNascimento;

Console.WriteLine("A idade da Dani é: " + idade3);

float trocadoMae = 2.20f;
float trocadoVo = 150.60f;

float trocadoTotal = trocadoMae + trocadoVo;

Console.WriteLine("O trocado foi de: R$" + trocadoTotal);

int numero01 = 6;
int numero02 = 2;

int multiplicacao = numero01 * numero02;
int divisao = numero01 / numero02;
int resto = numero01 % numero02;

Console.WriteLine($" O resultado da multiplicação é: {multiplicacao}");
Console.WriteLine($" O resultado da divisão é: {divisao}");
Console.WriteLine($" O resultado do resto da divisão é: {resto}");

Console.WriteLine("-----------------------------------------------");

Console.WriteLine("-----------OPERADORES LÓGICOS--------------");
// && - e -> ambas condições verdadeiras = ele entra no if
// || - ou -> se uma das condições for verdadeira = ele entra no if
// !  - não
int idadeDaBelly = 18;
bool suco = false;
bool roupaDeTime = true;
//!suco 
//suco == true
if (idadeDaBelly >= 18 && !suco || !roupaDeTime)
{
    Console.WriteLine("VAMOS COMEÇAR, TUTS TUTS TUTS");
}
else
{
    Console.WriteLine("Uma pena, é proíbido a entrada de menores de idade e consumos.");
}
Console.WriteLine("-----------------------------------------------");

Console.WriteLine("----------- OPERADORES CONDICIONAIS --------------");
// == - igual
// != - diferente
// <  - menor
// >  - maior
// <= - menor igual
// >= - maior igual

// int dindinDoRyan = int.Parse(Console.ReadLine()!);
// int dindinDoSillas = int.Parse(Console.ReadLine()!);
int dindinDoRyan = 2000;
int dindinDoSillas = 3000;

if (dindinDoRyan > dindinDoSillas)
{
    Console.WriteLine("O Ryan paga a pizza hoje!");
}
else if (dindinDoRyan < dindinDoSillas)
{
    Console.WriteLine("O Sillas paga a pizza hoje!");
}
else
{
    Console.WriteLine("Vão ter que rachar a contaaa! 🤪");
}

Console.WriteLine("-----------------------------------------------");

//switch case
string diaDaSemana = "Terça-feira";
//domiNGO
//DOMINGO
//domingo != Domingo != DOMINGO
switch (diaDaSemana.ToLower())
{
    case "domingo":
        Console.WriteLine("Domingou, hora do fantástico comendo pastel");
        break;
    case "segunda-feira":
        Console.WriteLine("Segundou, sono bravo");
        break;
    case "terça-feira":
        Console.WriteLine("Terçou, dia da pizza em dobro!");
        break;
    case "quarta-feira":
        Console.WriteLine("Quartouuu, hora da fejuca");
        break;
    case "quinta-feira":
        Console.WriteLine("Quintouuu, NÃO AGUENTO MAIS");
        break;
    case "sexta-feira":
        Console.WriteLine("Sextouu, dia de maldade 😎");
        break;
    case "sábado":
        Console.WriteLine("Sábado, faxina, pipoca e chocolate 😋");
        break;
    default:
        Console.WriteLine("ops esse dia no exist");
        break;
}

//Laços
Console.WriteLine("----------- LAÇOS DE REPETIÇÃO---------------");
//for(inicializador; condição; incrementa/decrementa)
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
//i-- == i - 1
//i++ == i + 1
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}

//while(condicao){}
bool amarVoce = true;

while (amarVoce)
{
    Console.WriteLine($"TE AMO ❤🤍🌻");
    amarVoce = false;
}
//do while
bool minerio = true;

do
{
    Console.WriteLine("Minerando...💎");
} while (minerio);

Console.WriteLine("-----------------------------------------------");
