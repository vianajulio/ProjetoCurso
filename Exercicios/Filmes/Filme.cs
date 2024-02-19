namespace ProjetoCurso.Exercicios.Filmes;

using System.Text.Json;
internal class Filme /*: Interface*/
{
    //public override void Executar()
    //{
    //    base.Executar();
    //    Mostrar();
    //}
    private static async Task Mostrar()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string respFilmes = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
                var filmes = JsonSerializer.Deserialize<List<FilmeDesserializer>>(respFilmes);
                filmes[4].MostarDetalhesFilme();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro {e.Message}");
            }
        }
    }
}