namespace ProjetoCurso.Exercicios.Livros;
using System.Text.Json;

using ProjetoCurso.UI;

internal class LivrosHttpClient : UIMenu
{
    public override async Task ExecutarMetodosExercicios()
    {
        await base.ExecutarMetodosExercicios();
        ExibirTituloDoExercicio("Exercício sobre Livros");
        await LivrosHttp();
    }
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
