using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Usando namespace
namespace tipos_de_dados.models.Pessoa
{
    // Aprendendo o uso de Classes no C#, a class Pessoa pussui dois atributos, nome e idade. Sua ação ou método se chama Apresentar e tem a função de imprimir na tela uma frase de apresentação;
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}