using System.Text.Json.Serialization;
namespace ProjetoCurso.Exercicios.Paises;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }
    [JsonPropertyName("capital")]
    public string? Capital { get; set; }
    [JsonPropertyName("populacao")]
    public int? Populacao { get; set; }
    [JsonPropertyName("continente")]
    public string? Continente { get; set; }
    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }

    public void EibirPaises()
    {
        Console.WriteLine($"\n* Nome: -> {Nome}");
        Console.WriteLine($"* Idioma: -> {Idioma}");
        Console.WriteLine($"* Continente: -> {Continente}");
        Console.WriteLine($"* Populacao: -> {Populacao}");
        Console.WriteLine($"* Capital: -> {Capital}\n");
    }
}
