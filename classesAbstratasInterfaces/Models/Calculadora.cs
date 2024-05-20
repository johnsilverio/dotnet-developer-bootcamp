using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using classesAbstratasInterfaces.Interfaces;

namespace classesAbstratasInterfaces.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2; 
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Substrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}