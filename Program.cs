using ProjetoCurso.Exercicios.Carro;
using ProjetoCurso.Exercicios.CheapShark;
using ProjetoCurso.Exercicios.Conta;
using ProjetoCurso.Exercicios.ContaBancaria;
using ProjetoCurso.Exercicios.Filmes;
using ProjetoCurso.Exercicios.Livros;
using ProjetoCurso.Exercicios.Paises;
using ProjetoCurso.UI;
using ProjetoCurso.Exercicios.Oficina;

namespace ProjetoCurso;
class Program
{
    public static async Task Main(string[] args)
    {
        Dictionary<string, UIMenu> opcoes = new();
        opcoes.Add("Carro", new InteCarro());
        opcoes.Add("Filmes", new Filmes());
        opcoes.Add("Conta", new Conta("Fraga", 100));
        opcoes.Add("ContaBancaria", new ContaBancaria(1, "Fraga", 100, 123));
        opcoes.Add("Cheap Shark HTTP", new CheapSharkHttpClient());
        opcoes.Add("Livros HTTP", new LivrosHttpClient());
        opcoes.Add("Pais", new PaisMain());
        opcoes.Add("Usuarios", new Usuarios());
        opcoes.Add("Oficina", new OficinaAuto());

        await UIMenu.ExibirOpcoes(opcoes);
    }
}