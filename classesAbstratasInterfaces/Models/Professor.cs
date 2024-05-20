using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classesAbstratasInterfaces.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {
            
        }

        public Professor(string nome) : base(nome)
        {
            
        }

       public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, o meu nome é {Nome}, tenho {Idade} anos, e ganho R$ {Salario:F2} por mês");
        }
    }
}