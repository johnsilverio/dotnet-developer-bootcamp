using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classesAbstratasInterfaces.Models
{
    public class Pessoa
    {
       public Pessoa()
       {
        
       }

       public Pessoa(string nome)
       {
            Nome = nome;
       }

       public string Nome { get; set; } 
       public int Idade { get; set; }
       // Virtual para permitir que seja usado o Polimorfismo em outra classe.
       public virtual void Apresentar()
       {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
       }
    }
}