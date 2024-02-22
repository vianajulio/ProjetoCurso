namespace ProjetoCurso.Exercicios.Filmes;

using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;
using System.Text.Json;

class Filmes : Menu, IMenu
{
    public override async Task ExecutarMetodosExercicios()
    {
        await base.ExecutarMetodosExercicios();
        ExibirTituloDoExercicio("Exercício sobre Filme");
        await MostrarDados();
    }
    public static async Task MostrarDados()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string respFilmes = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
                var filmes = JsonSerializer.Deserialize<List<FilmeDesserializer>>(respFilmes);
                filmes!.ForEach(filme => filme.MostarDetalhesFilme());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro {e.Message}");
            }
        }
    }
}