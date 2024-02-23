namespace ProjetoCurso.Exercicios.Livros;

using System.Net.Http.Headers;
using System.Text.Json;
using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;

internal class LivrosHttpClient : Menu, IMenu
{
    private string url = "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/";
    public override async Task ExecutarMetodosExercicios()
    {
        await base.ExecutarMetodosExercicios();
        await MostrarLivros();
    }
    HttpClient CriarCliente()
    {
        HttpClient _client = new HttpClient();
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        _client.BaseAddress = new Uri(url);
        return _client;
    }
    public async Task<string?> LivrosHttp()
    {
        try
        {
            string resLivros = await CriarCliente().GetStringAsync("Livros.json");
            return resLivros;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocorreu um erro {e.Message}");
            return null;
        }
    }

    async Task MostrarLivros()
    {
        string? resLivros = await LivrosHttp();
        if (resLivros != null && !resLivros.Equals(""))
        {
            var livros = JsonSerializer.Deserialize<List<Livros>>(resLivros);
            livros!.ForEach(filme => filme.MostrarDados());
        }
        else
        {
            Console.WriteLine("Erro ao recuperar dados.");
        }
    }
}
