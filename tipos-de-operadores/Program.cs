// ** TIPOS DE OPERADORES EM C# ** Este código existe apenas com o propósito de exercício lógico e estudo de sintaxe, apenas irá funcionar em um bloco de cada vez.

// Operadores de atribuição: básicamente há uma forma de abreviar X + X = Y usando a atribuição +=, isso se aplica também para subtração apenas trocando o operador (-=);
int b = 20;
int c = a + b;
int a = 10;
c += 5; 
Console.WriteLine(c);

// Convertendo Tipos de Variáveis, essa conversão é chamada de Cast ou Casting;
int a = Convert.ToInt32(null);
int b = int.Parse(null);

Console.WriteLine(a);
Console.WriteLine(b);

// Usando o método ToString;
int numero1 = 45;
int numero2 = 32;
int resultado = numero1 + numero2;

string resultadoEmString = resultado.ToString();
Console.WriteLine(resultadoEmString);

// Método MaxValue reforçando o cast implicito quando automáticamente há uma conversão nos tipos de dados;
int a = int.MaxValue;
long b = a;
Console.WriteLine(b);

// Usando o método TryParse para uma conversão de maneira mais segura;
string a = "15-";
int b = 0; 
int.TryParse(a, out int b);

Console.WriteLine();
Console.WriteLine("Conversão realizada com sucesso!");

// Operadores condional If e sua estrutura;
if (quantidadeCompra == 0)
{
    Console.WriteLine("Você não realizou uma compra.");
}
else if (possivelVenda)
{
    Console.WriteLine("Compra realizada!");
}
else
{
    Console.WriteLine("Desculpe, não temos essa quantidade em estoque!");
}

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

// Operador If aninhado;
if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
     Console.WriteLine("Vogal");
}
 else
{
     Console.WriteLine("Não é uma Vogal");
}

// Aplicando o Switch Case;
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É uma vogal!");
    break;

    default:
        Console.WriteLine("Não é uma vogal!");
        break;
}

// Entendendo o uso de Operadores Lógicos;
int quantidadeEmEstoque = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de compras: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// Aplicando Operador lógico OR (||);
bool eMaiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = false;

if (eMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada autorizada!");
}
else
{
    Console.WriteLine("Entrada não autorizada!");
}

// Aplicando Operador lógico AND (&&);
bool possuiPresencaMinima = false;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}

// Aplicando Operador Lógico NOT (!);
bool choveu = false;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Vou pedalar outro dia!");
}