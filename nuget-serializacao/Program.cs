using nuget_serializacao.Models;
using System.Globalization;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Sofware de Gestão", 7400.00M, dataAtual);
Venda v3 = new Venda(3, "Materiais de Construção", 300.00M, dataAtual);
Venda v4 = new Venda(4, "Refrigerador", 200.00M, dataAtual);
Venda v5 = new Venda(5, "Computadores", 20000.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);
listaVendas.Add(v3);
listaVendas.Add(v4);
listaVendas.Add(v5);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/venda.json", serializado);

Console.WriteLine(serializado);