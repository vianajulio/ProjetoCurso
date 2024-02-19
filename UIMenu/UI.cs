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
    public virtual async Task Executar()
    {
        Console.Clear();
    }
    public static void ExibirCabecalho()
    {
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

    public static async Task ExibirOpcoes(Dictionary<int, UIMenu> opcoes)
    {
        Console.WriteLine("Veja os exercicios realizados durante o curso:");
        Console.WriteLine("\n* Digite 1 para ver os exercicio sobre aceleração de carro;");
        Console.WriteLine("* Digite 2 para ver os exercicio sobre exibição das informações sobre CheapShark puxadas de uma API;");
        Console.WriteLine("* Digite 3 para ver os exercicio sobre exibição dos valores de uma conta;");
        Console.WriteLine("* Digite 4 para ver os exercicio sobre exibição dos valores de uma conta bancária;");
        Console.WriteLine("* Digite 5 para ver os exercicio sobre exibição das informações sobre Filmes puxadas de uma API;");
        Console.WriteLine("* Digite 6 para ver os exercicio sobre exibição das informações sobre Livros puxadas de uma API;");
        Console.Write("\n-> Sua resposta: ");
        string opcaoSelecionada = Console.ReadLine();
        int opcaoConverted = int.Parse(opcaoSelecionada);

        if (opcoes.ContainsKey(opcaoConverted))
        {
            UIMenu exercicioASerExibido = opcoes[opcaoConverted];
            await exercicioASerExibido.Executar();
        }
        else
        {
            Console.Clear();
            ExibirCabecalho();
            Console.WriteLine("***** Opção Inválida *****\n");
            await ExibirOpcoes(opcoes);
        }
    }
}
