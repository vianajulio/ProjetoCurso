using System.Text.Json;
namespace ProjetoCurso.Exercicios.Paises;
using ProjetoCurso.UIMenu;

class PaisMain : UIMenu
{
    public override async void Executar()
    {
        base.Executar();
        ExibirTituloDoExercicio("Exercício sobre Paises");
    }

    public static async Task MostrarDados()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
                var paises = JsonSerializer.Deserialize<List<Pais>>(response);

            }
            catch (Exception error)
            {
                Console.WriteLine($"OPS! Ocorreu um erro: {error.Message}");
            }
        }
    }
}