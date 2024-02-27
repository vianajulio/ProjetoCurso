using System.Text.Json;

namespace ProjetoCurso.Exercicios.Paises;

using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

class PaisMain : Menu, IMenu
{
    public async Task ExecutarMetodosExercicios()
    {
        await MostrarDados();
    }

    public static async Task MostrarDados()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
                var paises = JsonSerializer.Deserialize<List<Pais>>(response);
                paises!.ForEach(pais => pais.EibirPaises());
            }
            catch (Exception error)
            {
                Console.WriteLine($"OPS! Ocorreu um erro: {error.Message}");
            }
        }
    }
}