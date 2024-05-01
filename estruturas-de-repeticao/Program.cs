using System;

// Exemplo inicial, nessa situação, teríamos que repetir o Console.WriteLine até 10;
// int numero = 10;
// Console.WriteLine($"{numero} x 1 = {numero * 1}");

// Introdução ao FOR, sintaxe: (Declaração da variável, condição e o incremento);

int numero = 5;
for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

// Introdução ao WHILE (Enquanto uma condição estiver acontecendo);
int numero2 = 6;
int contador2 = 0;

while (contador2 <= 10)
{
    Console.WriteLine($"{contador2}° Execução: {numero2} x {contador2} = {numero2 * contador2}");
    contador2++;
}

// Utilizando o Break para quebrar o loop;
int numero3 = 7;
int contador3 = 0;

while (contador3 <= 10)
{
    Console.WriteLine($"{numero3} x {contador3} = {numero3 * contador3}");
    contador3++;

    if (contador3 == 7)
    {
        break;
    }
}

// DO WHILE (faça isso enquanto condição X acontecer)
int soma = 0, numero4 = 0;

do
{
    Console.WriteLine("Digite um número (O para parar): ");
    numero4 = Convert.ToInt32(Console.ReadLine());

    soma += numero4; 

} while (numero4 != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// Exemplo de Menu interativo usando loop.

string? opcao;

while(true)
{
    Console.Clear();
    Console.WriteLine("\n Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente: ");
    Console.WriteLine("2 - Buscar cliente: ");
    Console.WriteLine("3 - Apagar cliente: ");
    Console.WriteLine("4 - Encerrar: \n");

    opcao = Console.ReadLine();

    switch(opcao)
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
            Environment.Exit(0);
            break;
        
        default: 
            Console.WriteLine("Opção inválida");
            break;
    }
}