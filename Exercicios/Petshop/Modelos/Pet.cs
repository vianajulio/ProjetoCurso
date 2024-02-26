using System.Globalization;

namespace Petshop.Modelos;

internal class Pet
{
    public string Nome { get; set; }
    public string Especie { get; set; }
    public string Raca { get; set; }
    public string Cor {  get; set; }

    public Pet(string nome, string especie, string raca, string cor)
    {
        Nome = nome;
        Especie = especie;
        Raca = raca;
        Cor = cor;
    }

    public void ExibirInformacoesPet()
    {
        Console.WriteLine($"\nSegue as informacoes do {Nome}");
        Console.WriteLine($" -> Nome: {Nome}");
        Console.WriteLine($" -> Espécie: {Especie}");
        Console.WriteLine($" -> Raca: {Raca}");
        Console.WriteLine($" -> Cor: {Cor}");
    }
}
