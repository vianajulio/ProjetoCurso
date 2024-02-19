using ProjetoCurso.Exercicios.Livros;

class Program
{
    static async Task Main()
    {
        await LivrosHttpClient.LivrosHttp();
    }
}
