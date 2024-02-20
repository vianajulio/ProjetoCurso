namespace ProjetoCurso.Exercicios.Filmes;


using ProjetoCurso.UI;
using System.Text.Json;

internal class CarroJSON : UIMenu
{
    public override async Task Executar()
    {
        await base.Executar();
        ExibirTituloDoExercicio("Exercício sobre Filme");
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

    public override string NomeUI()
    {
        return "Carro JSON";
    }
}