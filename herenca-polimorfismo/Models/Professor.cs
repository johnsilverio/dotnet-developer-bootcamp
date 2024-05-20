using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace herenca_polimorfismo.Models
{
    public class Professor : Pessoa
    {
       public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, o meu nome é {Nome}, tenho {Idade} anos, e ganho R$ {Salario:F2} por mês");
        }
    }
}