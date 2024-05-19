using  abstracao_encapsulamento.Models;

// Criando objeto da classe Pessoa
Pessoa p1 = new Pessoa();
p1.Nome = "John";
p1.Idade = 20;

p1.Apresentar(); 

// Usando encapsulamento
ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();
