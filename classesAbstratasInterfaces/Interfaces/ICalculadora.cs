using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classesAbstratasInterfaces.Interfaces
{
    public interface ICalculadora
    {
       int Somar(int num1, int num2); 
       int Substrair (int num1, int num2); 
       int Multiplicar (int num1, int num2); 
       int Dividir (int num1, int num2); 
    }
}