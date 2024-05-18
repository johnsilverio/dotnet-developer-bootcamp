using TuplasOpTenario.Models;
using System.Globalization;
using tuplas_opternario.Models;

// If não ternário
//int numero = 15;
//if (numero % 2 == 0)
//{
//    Console.WriteLine($"O número {numero} é par");
//}
//else
//{
//    Console.WriteLine($"O número {numero} é ímpar");
//}

// If ternário
int numero = 20;
bool ehPar = false;

ehPar = numero % 2 ==0;

Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

// Deconstrutor
Pessoa p1 = new Pessoa("John", "Silverio");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}"); 


// Usando Tuplas na Prática
LeituraArquivos arquivo = new LeituraArquivos();

var (sucesso, linhasArquivos, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    //Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadedeLinhas}");
    foreach (string linha in linhasArquivos)
    {
        Console.WriteLine(linha);
    }
}
else 
{
    Console.WriteLine("Não foi possível ler o arquivo");
}















// Trabalhando com Tuplas
//(int, string, string, decimal) tupla = (1, "John", "Silverio", 10.5M);
//ValueTuple<int, string, string, decimal> exemploDeTupla = (2, "Johan", "Liebert", 1.80M);
//var exemploDeTupla2 = Tuple.Create(3, "Leonardo", "Buta", 1.80M);

//Console.WriteLine($"Id: {tupla.Item1}");
//Console.WriteLine($"Nome: {tupla.Item2}");
//Console.WriteLine($"Sobrenome: {tupla.Item3}");
//Console.WriteLine($"Altura: {tupla.Item4}");