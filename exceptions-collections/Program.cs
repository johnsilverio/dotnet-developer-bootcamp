using exceptions_collections.Models;
using ExceptionsCollections.Models;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("MT", "Mato Grosso");
estados.Add("PR", "Paraná");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("---------");

estados.Remove("BA");
estados["PR"] = "Paraná - Valor atualizado";
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}





//Stack<int> pilha = new Stack<int>();
//
//pilha.Push(4);
//pilha.Push(6);
//pilha.Push(8);
//pilha.Push(10);
//
//foreach(int item in pilha)
//{
//    Console.WriteLine(item);
//}
//
//Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
//
//pilha.Push(20);
//
//foreach(int item in pilha)
//{
//    Console.WriteLine(item);
//}






// Filas em C#
//Queue<int> fila = new Queue<int>();
//
//fila.Enqueue(2);
//fila.Enqueue(4);
//fila.Enqueue(6);
//fila.Enqueue(8);
//
//foreach(int item in fila)
//{
//    Console.WriteLine(item);
//}
//
//Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
//fila.Enqueue(10);
//foreach(int item in fila)
//{
//    Console.WriteLine(item);
//}
//new ExemploExcecao().Metodo1();
//try
//{
//    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//
//    foreach(string linha in linhas)
//    {
//        Console.WriteLine(linha);
//    }
//}
//catch(FileNotFoundException ex)
//{
//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
//}
//catch(DirectoryNotFoundException ex)
//{
//    Console.WriteLine($"Ocorreu um erro na leitura do diretório. Caminho da pasta não encontrado. {ex.Message}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
//} finally 
//{
//    Console.WriteLine("Chegou até aqui!!");
//} 
//
//