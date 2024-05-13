using ExemploExplorando.Models;

// Usando contrutuor
Pessoa p1 = new Pessoa(nome: "John", sobrenome: "Silverio");
// Sem usar construtor
Pessoa p2 = new Pessoa();
p2.Nome = "Duda";
p2.Sobrenome = "Queiroz";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAlunos(p1);
cursoDeIngles.AdicionarAlunos(p2);
cursoDeIngles.ListarAlunos();


// Pessoa p1 = new Pessoa();
// p1.Nome = "John";
// p1.Sobrenome = "Silverio";
// p1.Idade = 22;
// p1.Apresentar();