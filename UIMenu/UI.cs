using ProjetoCurso.Interfaces;

namespace ProjetoCurso.UIMenu;

internal class Menu : IMenu
{
    public static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine(@"
          _____                                                   _____                         
         |  __ \                                                 / ____|                        
         | |__) |_ __  ___    __ _  _ __  ___  ___  ___   ___   | |     _   _  _ __  ___   ___  
         |  ___/| '__|/ _ \  / _` || '__|/ _ \/ __|/ __| / _ \  | |    | | | || '__|/ __| / _ \ 
         | |    | |  | (_) || (_| || |  |  __/\__ \\__ \| (_) | | |____| |_| || |   \__ \| (_) |
         |_|    |_|   \___/  \__, ||_|   \___||___/|___/ \___/   \_____|\__,_||_|   |___/ \___/ 
                              __/ |                                                             
                             |___/                                                              
        ");
        Console.WriteLine("Bem vindo! Aqui você poderá acompanhar a evolução dos Devs Jr's.\n\n\n");
    }
    public static void ExibirTituloDoExercicio(string titulo)
    {
        int tamanhoTitulo = titulo.Length;
        string asteriscos = string.Empty.PadLeft(tamanhoTitulo, '*');
        Console.WriteLine(asteriscos + "****");
        Console.WriteLine("* " + titulo + " *");
        Console.WriteLine(asteriscos + "****" + "\n");
    }

    public virtual async Task ExecutarMetodosExercicios() {}

    public static void LimparTela()
    {
        Console.Clear();
    }

    public static void ErroInput(string erro = "")
    {
        Console.Clear();
        Console.WriteLine($"OCORREU UM ERRO: \n{erro}");
        Console.WriteLine("Aperte uma tecla para voltar ao menu\n");
        Console.ReadKey();
    }

    public static string LinhasListaOpcoes()
    {
        int tamanhoMax = 60;
        string linha = new string('-', tamanhoMax);
        return linha;
    }

    public static async Task ExecutarMenu(Dictionary<string, Menu> opcoes)
    {
        while (true)
        {
            ExibirCabecalho();
            OpcaoMenu.ExibirOpcoes(opcoes);
            await OpcaoMenu.ExecutarExercicioSelecionado(opcoes);
        }
    }
}
