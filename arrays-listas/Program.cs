using System;

// Implementando um Array de números inteiros;
int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

// ** Copiando um Array **
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);  

  // ** Uma forma de redimensionar meu Array; **
 // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Percorrendo o Array com o FOR
Console.WriteLine("Percorrendo o Array com  o For");

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

// Percorrendo o Array com  o Foreach;
Console.WriteLine("Percorrendo o Array com  o Foreach");

foreach (int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}

// Trabalhando com LISTAS 

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("PR");
listaString.Add("MG");

// Usando o For para percorrer listas;
Console.WriteLine("Percorrendo uma lista com  o For");
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

// Usansdo Foreach em Listas;
Console.WriteLine("Percorrendo uma lista com  o Foreach");

int contadorForeach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição N° {contadorForeach} - {item}");
    contadorForeach++;
}