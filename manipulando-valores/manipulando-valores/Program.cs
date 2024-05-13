using ManipulandoValores.Models;
using System.ComponentModel;
using System.Globalization;
// MANIPULANDO VALORERS E FORMATAÇÕES EM C#

// Definindo a cultura;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;
Console.WriteLine($"{valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));

DateTime data = DateTime.Now;  
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortTimeString());

string dataString = "2022-03-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, out DateTime dataParse);
Console.WriteLine(dataParse);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}
//int numero1 = 10;
//int numero2 = 20;
//
//int resultado = numero1 + numero2;
//
// Console.WriteLine(resultado);

//Pessoa p1 = new Pessoa(nome: "John", sobrenome: "Silverio");
//
//Pessoa p2 = new Pessoa();
//p2.Nome = "Alanis";
//p2.Sobrenome = "Grespan";
//
//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Inglês";
//cursoDeIngles.Alunos = new List<Pessoa>();
//
//cursoDeIngles.AdicionarAlunos(p1);
//cursoDeIngles.AdicionarAlunos(p2);
//cursoDeIngles.ListarAlunos();
