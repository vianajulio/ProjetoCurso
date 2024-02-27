using System.Text.Json.Serialization;

namespace ProjetoCurso.Exercicios.Filmes;

class FilmeDesserializer
{
    [JsonPropertyName("title")]
    public string? Nome { get; set; }
    [JsonPropertyName("year")]
    public string? AnoL{ get; set;}
    [JsonPropertyName("crew")]
    public string? Direcao { get; set; }
    [JsonPropertyName("rank")]
    public string? Classificacao { get; set; }

    public void MostarDetalhesFilme()
    {
        Console.WriteLine($"Classificação entre os demais {Classificacao}");
        Console.WriteLine($"Nome do Filme: {Nome}");
        Console.WriteLine($"Ano de lançamento: {AnoL}");
        Console.WriteLine($"Dirigido por: {Direcao}");
        Console.WriteLine();
    }

}
