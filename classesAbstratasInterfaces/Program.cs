using System.Runtime.InteropServices;
using classesAbstratasInterfaces.Interfaces;
using classesAbstratasInterfaces.Models;

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();

Pessoa p1 = new Pessoa("John");
Aluno a1 = new Aluno("Eduardo");
a1.Apresentar(); 

Computador c1 = new Computador();
Console.WriteLine(c1.ToString());


ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));