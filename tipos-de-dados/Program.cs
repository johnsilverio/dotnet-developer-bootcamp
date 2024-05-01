using tipos_de_dados.models.Pessoa;

// Primeiro programa (conforme a tradição).
Console.WriteLine("Hello, World!");

// Entendendo uma Classe:
Pessoa pessoa1 = new Pessoa(); 
pessoa1.Nome = "John";
pessoa1.Idade = 22;
pessoa1.Apresentar();

// Tipos de Dados:
string apresentacao = "Olá seja bem vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

// Imprimindo os tipos de dados:
Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);

// Usando o DateTime:
DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));