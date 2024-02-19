using System.Text.Json;
namespace ProjetoCurso.Exercicios.Filmes;
class Filme
{
    public static async     Task
MostrarDados()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string respFilmes = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
                var filmes = JsonSerializer.Deserialize<List<FilmeDesserializer>>(respFilmes);
                //filmes[2].MostarDetalhesFilme();
                filmes.ForEach(filme => filme.MostarDetalhesFilme());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro {e.Message}");
            }
        }
    }
}