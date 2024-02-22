using System.Linq;

namespace ProjetoCurso.UIMenu;

internal class OpcaoMenu : Menu
{
    private static List<KeyValuePair<string, Menu>> ConverterDicionarioParaLista(Dictionary<string, Menu> opcoes)
    {
        List<KeyValuePair<string, Menu>> listaOpcoes = opcoes.ToList();
        return listaOpcoes;
    }

    public static void ExibirOpcoes(Dictionary<string, Menu> opcoes)
    {
        var listaOpcoes = ConverterDicionarioParaLista(opcoes);
        listaOpcoes.ForEach(x => Console.WriteLine());
        Console.WriteLine("Veja os exercicios realizados durante o curso:");
        Console.WriteLine("Digite o número correspondente para acessar o exercício:\n");

        Console.WriteLine(LinhasListaOpcoes());
        Console.WriteLine("* Digite -1 para sair *");
        for (int i = 0; i < listaOpcoes.Count; i++)
        {
            string opcaoExibida = $"* {i}: {listaOpcoes[i].Key}";
            Console.WriteLine($"{LinhasListaOpcoes()}\n{opcaoExibida}");
        }
        Console.WriteLine(LinhasListaOpcoes());
    }
    private static int SelecionarOpcao()
    {
        Console.Write("\n-> Sua resposta: ");
        string numeroOpcao = Console.ReadLine() ?? "";
        try
        {
            int opcaoConverted = int.Parse(numeroOpcao);
            if (opcaoConverted == -1)
            {
                Environment.Exit(0);
            }
            return opcaoConverted;
        }
        catch
        {
            ErroInput();
            return -1;
        }
    }

    public static async Task ExecutarExercicioSelecionado(Dictionary<string, Menu> opcoes)
    {
        var listaOpcoes = ConverterDicionarioParaLista(opcoes);
        var opcaoSelecionada = listaOpcoes[SelecionarOpcao()];
        Menu exercicioASerExibido = opcaoSelecionada.Value;
        ExibirTituloDoExercicio(opcaoSelecionada.Key);
        await exercicioASerExibido.ExecutarMetodosExercicios();
        Console.ReadKey();
    }
}
