using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace operadores_aritmeticos.models
{
  public class Calculadora
  {
    // Calculos Básicos usando a função Math;
    public void Somar(int x, int y)
    {
      Console.WriteLine($"{x} + {y} = {x + y}");
    }
    public void Subtrair(int x, int y)
    {
      Console.WriteLine($"{x} - {y} = {x - y}");
    }
    public void Multiplicar(int x, int y)
    {
      Console.WriteLine($"{x} * {y} = {x * y}");
    }
    public void Dividir(int x, int y)
    {
      Console.WriteLine($"{x} / {y} = {x / y}");
    }
    // Elevar a potência;
    public void Potencia(int x, int y)
    {
      double pot = Math.Pow(x, y);
      Console.WriteLine($"{x}^{y} = {pot}");
    }
    // Trigonometria como podemos fazer usando a função Math;
    public void Seno(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double seno = Math.Sin(radiano);
      Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
    }
    public void Coseno(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double coseno = Math.Cos(radiano);
      Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
    }
    public void Tangente(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double tangente = Math.Tan(radiano);
      Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
    }
    // Como calcular a raiz quadrada;
    public void RaizQuadrada(double x)
    {
      double raiz = Math.Sqrt(x);
      Console.WriteLine($"Raiz quadrada de {x} é {raiz}");
    }
  }
}
