using System.Text.Json;

namespace ProjetoCurso.Exercicios.CheapShark;

using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

internal class CheapSharkHttpClient : IMenu
{
    public async Task ExecutarMetodosExercicios()
    {
        await CheapSharkHttp();
    }
    public static async Task CheapSharkHttp()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string response = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
                var cheapShark = JsonSerializer.Deserialize<List<CheapShark>>(response);
                cheapShark!.ForEach(filme => filme.MostrarDados());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro {e.Message}");
            }
        }
    }
}
