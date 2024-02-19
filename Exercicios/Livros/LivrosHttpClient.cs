using System.Text.Json;

namespace ProjetoCurso.Exercicios.Livros;

internal class LivrosHttpClient
{
    public static async Task LivrosHttp()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string resLivros = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
                var livros = JsonSerializer.Deserialize<List<Livros>>(resLivros);
                livros!.ForEach(filme => filme.MostrarDados());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro {e.Message}");
            }
        }
    }
}
