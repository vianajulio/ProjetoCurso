using System.Text.Json.Serialization;

namespace ProjetoCurso.Exercicios.Filmes;

class CarroDesserializer
{
    [JsonPropertyName("marca")]
    public string? Marca { get; set; }
    [JsonPropertyName("modelo")]
    public string? Modelo { get; set; }
    [JsonPropertyName("ano")]
    public string? Ano { get; set; }
    [JsonPropertyName("tipo")]
    public string? Classificacao { get; set; }
    [JsonPropertyName("motor")]
    public string? Motor { get; set; }
    [JsonPropertyName("transmissao")]
    public string? Transmissao { get; set; }

    public void MostrarDetalhesCarros()
    {
        Console.WriteLine($"Marca do veiculo: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Classificação{Classificacao}");
        Console.WriteLine($"Motorização: {Motor}");
        Console.WriteLine($"Transmissão: {Transmissao}");
    }

}
