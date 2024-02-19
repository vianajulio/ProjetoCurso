using System.Text.Json;

namespace ProjetoCurso.Exercicios.CheapShark;

using ProjetoCurso.UI;
internal class CheapSharkHttpClient : UIMenu
{
    public override async Task Executar()
    {
        await base.Executar();
        ExibirTituloDoExercicio("Exercício sobre CheapShark");
        await CheapSharkHttp();
    }
    public static async Task CheapSharkHttp()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
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
