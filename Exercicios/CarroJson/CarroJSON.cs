namespace ProjetoCurso.Exercicios.Filmes;

using ProjetoCurso.UIMenu;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

internal class CarroJSON : Menu
{
    public async Task ExecutarMetodosExercicios()
    {
        await MostrarDadosCarros();
    }

    public static async Task MostrarDadosCarros()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string respCarros = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
                var carros = JsonSerializer.Deserialize<List<CarroDesserializer>>(respCarros);
                carros!.ForEach(carros => carros.MostrarDetalhesCarros());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro {e.Message}");
            }
        }
    }
}