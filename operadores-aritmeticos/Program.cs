using operadores_aritmeticos.models;

Calculadora calc = new Calculadora();

// Calculos básicos usando a função Math referenciado no Models;
calc.Somar(5, 5);
calc.Dividir(10, 50);
calc.Subtrair(10, 40);
calc.Multiplicar(10, 30);

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

calc.RaizQuadrada(9);

// Incremento numérico:

int numeroIncremento = 10;

Console.WriteLine(numeroIncremento);

Console.WriteLine("Incrementando o 10");
//numeroIncremento += 1;

numeroIncremento++;
Console.WriteLine(numeroIncremento);

// Decremento numérico:

int numeroDecremento = 20;

Console.WriteLine(numeroDecremento);

Console.WriteLine("Decrementando o 20");
numeroDecremento--;

Console.WriteLine(numeroDecremento);