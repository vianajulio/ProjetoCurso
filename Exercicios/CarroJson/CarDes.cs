namespace ProjetoCurso.Exercicios.Filmes;
using System.Text.Json;
using ProjetoCurso.UIMenu;

internal class CarDes : UIMenu
{
    public override async Task Executar()
    {
        base.Executar();
        ExibirTituloDoExercicio("Exercício sobre Filme");
        MostrarDadosCarros();
    }

    public static async Task
MostrarDadosCarros()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string respCarros = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
                var carros = JsonSerializer.Deserialize<List<CarroDesserializer>>(respCarros);
                //filmes[2].MostarDetalhesFilme();
                carros.ForEach(carros => carros.MostrarDetalhesCarros());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro {e.Message}");
            }
        }
    }
}