using ProjetoCurso;
using System.Text.Json;
internal class Filme
{
    private static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string respFilmes = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
                var filmes = JsonSerializer.Deserialize<List<FilmeDesserializer>>(respFilmes);
                filmes[4].MostarDetalhesFilme();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro {e.Message}");
            }
        }
    }
}