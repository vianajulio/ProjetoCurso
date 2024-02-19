using ProjetoCurso.Exercicios.Filmes;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello!");

        await Filme.MostrarDados();
    }
}