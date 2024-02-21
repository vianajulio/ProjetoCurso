namespace ProjetoCurso.UIMenu;

internal class OpcaoMenu
{
    private static List<KeyValuePair<string, Menu>> ConverterDicionarioParaLista(Dictionary<string, Menu> opcoes)
    {
        List<KeyValuePair<string, Menu>> listaOpcoes = opcoes.ToList();
        return listaOpcoes;
    }
    public static void ExibirOpcoes(Dictionary<string, Menu> opcoes)
    {
        var listaOpcoes = ConverterDicionarioParaLista(opcoes);

        Console.WriteLine("Veja os exercicios realizados durante o curso:");
        Console.WriteLine("\n* Digite -1 para sair *");
        for (int i = 0; i < listaOpcoes.Count; i++)
        {
            Console.WriteLine($"* Digite {i} para ver o exercicio sobre {listaOpcoes[i].Key} *");
        }
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
            Menu.ErroInput();
            return -1;
        }
    }

    public static async Task ExecutarExercicio(Dictionary<string, Menu> opcoes)
    {
        var listaOpcoes = ConverterDicionarioParaLista(opcoes);
        var opcaoSelecionada = listaOpcoes[SelecionarOpcao()];
        Menu exercicioASerExibido = opcaoSelecionada.Value;
        Menu.ExibirTituloDoExercicio(opcaoSelecionada.Key);
        await exercicioASerExibido.ExecutarMetodosExercicios();
    }
}
