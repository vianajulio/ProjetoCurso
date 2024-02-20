using ProjetoCurso.Exercicios.Carro;
using ProjetoCurso.Exercicios.CheapShark;
using ProjetoCurso.Exercicios.Conta;
using ProjetoCurso.Exercicios.ContaBancaria;
using ProjetoCurso.Exercicios.Filmes;
using ProjetoCurso.Exercicios.Livros;
using ProjetoCurso.Exercicios.Paises;
using ProjetoCurso.UIMenu;

Dictionary<int, UIMenu> opcoes = new();
opcoes.Add(1, new InteCarro());
opcoes.Add(2, new CheapSharkHttpClient());
opcoes.Add(3, new Conta("Fraga", 100));
opcoes.Add(4, new ContaBancaria(1, "Fraga", 100, 123));
opcoes.Add(5, new Filme());
opcoes.Add(6, new LivrosHttpClient());
opcoes.Add(7, new PaisMain());

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
    Console.WriteLine("* Digite 2 para ver os exercicio sobre exibição de informações sobre CheapShark puxadas de uma API;");
    Console.WriteLine("* Digite 3 para ver os exercicio sobre exibição dos valores de uma conta;");
    Console.WriteLine("* Digite 4 para ver os exercicio sobre exibição dos valores de uma conta bancária;");
    Console.WriteLine("* Digite 5 para ver os exercicio sobre exibição de informações sobre Filmes puxadas de uma API;");
    Console.WriteLine("* Digite 6 para ver os exercicio sobre exibição de informações sobre Livros puxadas de uma API;");
    Console.WriteLine("* Digite 7 para ver os exercicio sobre exibição de informações sobre Paises puxadas de uma API;");
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