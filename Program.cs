using ProjetoCurso.Exercicios.Carro;
using ProjetoCurso.Exercicios.CheapShark;
using ProjetoCurso.Exercicios.Conta;
using ProjetoCurso.Exercicios.ContaBancaria;
using ProjetoCurso.Exercicios.Filmes;
using ProjetoCurso.Exercicios.Livros;
using ProjetoCurso.Exercicios.Paises;
using ProjetoCurso.UI;

namespace ProjetoCurso;
class Program
{
    public static async Task Main(string[] args)
    {
        Dictionary<int, UIMenu> opcoes = new();
        opcoes.Add(1, new InteCarro());
        opcoes.Add(2, new CheapSharkHttpClient());
        opcoes.Add(3, new Conta("Fraga", 100));
        opcoes.Add(4, new ContaBancaria(1, "Fraga", 100, 123));
        opcoes.Add(5, new Filmes());
        opcoes.Add(6, new LivrosHttpClient());
        opcoes.Add(7, new PaisMain());

        await UIMenu.ExibirOpcoes(opcoes);
    }
}
