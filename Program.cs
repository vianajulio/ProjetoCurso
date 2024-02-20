using ProjetoCurso.Exercicios.Carro;
using ProjetoCurso.Exercicios.CheapShark;
using ProjetoCurso.Exercicios.Conta;
using ProjetoCurso.Exercicios.ContaBancaria;
using ProjetoCurso.Exercicios.Estoque;
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
<<<<<<< HEAD
        opcoes.Add(7, new EstoqueProdutos());
=======
        opcoes.Add(7, new PaisMain());
>>>>>>> 9dd0d7b68e3d8b16158aa7edf38657b132c916ef

        await UIMenu.ExibirOpcoes(opcoes);
    }
}
