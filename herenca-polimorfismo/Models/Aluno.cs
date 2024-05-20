using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace herenca_polimorfismo.Models
{
    public class Aluno : Pessoa
    {
       public int Nota { get; set; }

        // Override é usado para modificar o método herdado pela classe pai.
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}