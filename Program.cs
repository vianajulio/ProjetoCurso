using ProjetoCurso.Exercicios.Carro;
using ProjetoCurso.UIMenu;

Dictionary<int, UIMenu> opcoes = new();
opcoes.Add(1, new InteCarro());

void ExibirCabecalho()
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

void ExibirOpcoes()
{
    Console.WriteLine("Veja os exercicios realizados durante o curso:");
    Console.WriteLine("\n* Digite 1 para ver os exercicio sobre aceleração de carro;");
    Console.Write("\n-> Sua resposta: ");
    string opcaoSelecionada = Console.ReadLine();
    int opcaoConverted = int.Parse(opcaoSelecionada);

    if (opcoes.ContainsKey(opcaoConverted))
    {
        UIMenu exercicioASerExibido = opcoes[opcaoConverted];
        exercicioASerExibido.Executar();
    }
    else
    {
        Console.Clear();
        ExibirCabecalho();
        Console.WriteLine("***** Opção Inválida *****\n");
        ExibirOpcoes();
    }

}

async void main()
{
    ExibirCabecalho();
    ExibirOpcoes();
}

main();