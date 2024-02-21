namespace ProjetoCurso.UI;

internal class UIMenu
{
    public void ExibirTituloDoExercicio(string titulo)
    {
        int tamanhoTitulo = titulo.Length;
        string asteriscos = string.Empty.PadLeft(tamanhoTitulo, '*');
        Console.WriteLine(asteriscos + "****");
        Console.WriteLine("* " + titulo + " *");
        Console.WriteLine(asteriscos + "****" + "\n");
    }

    public virtual async Task ExecutarMetodosExercicios()
    {
        Console.Clear();
    }
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

    static void ErroInput()
    {
        Console.Clear();
        ExibirCabecalho();
        Console.WriteLine("Opção Inválida!");
        Console.WriteLine("Aperte uma tecla para voltar ao menu\n");
    }

    public static async Task ExibirOpcoes(Dictionary<string, UIMenu> opcoes)
    {
        ExibirCabecalho();

        List<KeyValuePair<string, UIMenu>> listaOpcoes = opcoes.ToList();

        Console.WriteLine(listaOpcoes[0].Key);

        Console.WriteLine("Veja os exercicios realizados durante o curso:");
        Console.WriteLine("\n* Digite -1 para sair *");
        for (int i = 0; i < listaOpcoes.Count; i++)
        {
            Console.WriteLine($"* Digite {i} para ver o exercicio sobre {listaOpcoes[i].Key} *");
        }
        Console.Write("\n-> Sua resposta: ");
        string numeroOpcao = Console.ReadLine() ?? "";
        try
        {
            int opcaoConverted = int.Parse(numeroOpcao);
            if (opcaoConverted == -1)
            {
                Environment.Exit(0);
                ErroInput();
                await ExibirOpcoes(opcoes);
            }
            var opcaoSelecionada = listaOpcoes[opcaoConverted];
            UIMenu exercicioASerExibido = opcaoSelecionada.Value;
            await exercicioASerExibido.ExecutarMetodosExercicios();

            Console.WriteLine("Clique em qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Console.Clear();
            await ExibirOpcoes(opcoes);
        }
        catch
        {
            ErroInput();
            Console.ReadKey();
            await ExibirOpcoes(opcoes);
        }
    }
}
