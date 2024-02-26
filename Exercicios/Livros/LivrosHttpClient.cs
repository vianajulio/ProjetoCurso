namespace ProjetoCurso.Exercicios.Livros;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;

public class LivrosHttpClient : Menu, IMenu
{
    private HttpClient client;
    public LivrosHttpClient(HttpClient client)
    {
        this.client = client;
    }
    public override async Task ExecutarMetodosExercicios()
    {
        await base.ExecutarMetodosExercicios();
        await MostrarLivros();
    }

    public async Task<string?> ListaLivrosAPI()
    {
        try
        {
            string resLivros = await client.GetStringAsync("Livros.json");
            return resLivros;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocorreu um erro {e.Message}");
            return null;
        }
    }

    public async Task MostrarLivros()
    {
        string? resLivros = await ListaLivrosAPI();
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
