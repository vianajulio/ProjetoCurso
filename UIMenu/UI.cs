﻿namespace ProjetoCurso.UI;

internal class UIMenu
{
    public virtual string NomeUI()
    {
        return "";
    }

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

    public static async Task ExibirOpcoes(Dictionary<int, UIMenu> opcoes)
    {
        ExibirCabecalho();

        Console.WriteLine(opcoes.ToList()[0].Value.NomeUI());

        Console.WriteLine("Veja os exercicios realizados durante o curso:");
        Console.WriteLine("\n* Digite 0 para sair *");
        opcoes.ToList().ForEach(opcao => { Console.WriteLine($"* Digite {opcao.Key} para ver o exercicio sobre {opcao.Value.NomeUI()} *"); });
        Console.Write("\n-> Sua resposta: ");
        string opcaoSelecionada = Console.ReadLine() ?? "";
        try
        {
            int opcaoConverted = int.Parse(opcaoSelecionada);

            if (opcoes.ContainsKey(opcaoConverted))
            {
                UIMenu exercicioASerExibido = opcoes[opcaoConverted];
                await exercicioASerExibido.Executar();

                Console.WriteLine("Clique em qualquer tecla para voltar ao menu.");
                Console.ReadKey();
                Console.Clear();
                await ExibirOpcoes(opcoes);
            }
            else if (opcaoConverted == 0)
            {
                Environment.Exit(0);
            }
            ErroInput();
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
