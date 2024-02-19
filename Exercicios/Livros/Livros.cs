
using System.Text.Json.Serialization;

namespace ProjetoCurso.Exercicios.Livros;
internal class Livros
{
    [JsonPropertyName("titulo")]
    public string Titulo { get; set; }

    [JsonPropertyName("autor")]
    public string Autor { get; set; }

    [JsonPropertyName("ano_publicacao")]
    public int Ano_publicacao { get; set; }

    [JsonPropertyName("genero")]
    public string Genero { get; set; }

    [JsonPropertyName("paginas")]
    public int Paginas { get; set; }

    [JsonPropertyName("editora")]
    public string Editora { get; set; }

    public Livros(string titulo, string autor, int ano_publicacao, string genero, int paginas, string editora)
    {
        Titulo = titulo;
        Autor = autor;
        Ano_publicacao = ano_publicacao;
        Genero = genero;
        Paginas = paginas;
        Editora = editora;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Titulo: {Titulo}\nAutor: {Autor}\nAno_publicacao: {Ano_publicacao}\nGenero: {Genero}\nPaginas: {Paginas}\nEditora: {Editora}\n");
    }

}