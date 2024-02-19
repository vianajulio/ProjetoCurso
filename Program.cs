﻿using ProjetoCurso.Exercicios.Carro;
using ProjetoCurso.Exercicios.Conta;
using ProjetoCurso.Exercicios.ContaBancaria;
using ProjetoCurso.Exercicios.Divisao;
using ProjetoCurso.Exercicios.Filmes;
using ProjetoCurso.Exercicios.Livros;
using ProjetoCurso.UIMenu;

Dictionary<int, UIMenu> opcoes = new();
opcoes.Add(1, new InteCarro());
opcoes.Add(2, new Filme());
opcoes.Add(3, new LivrosHttpClient());
opcoes.Add(4, new ContaBancaria(1, "Caina", 10000, 12345));
opcoes.Add(5, new Conta("Caina", 10000));
opcoes.Add(6, new InteCarro());
opcoes.Add(7, new InteCarro());
opcoes.Add(8, new Divisao());

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

async Task ExibirOpcoes()
{
    Console.WriteLine("Veja os exercicios realizados durante o curso:");
    Console.WriteLine("\n* Digite 1 para ver os exercicio sobre aceleração de carro;");
    Console.WriteLine("\n* Digite 2 para ver os exercicio sobre Filmes;");
    Console.WriteLine("\n* Digite 3 para ver os exercicio sobre Livros;");
    Console.WriteLine("\n* Digite 4 para ver os exercicio sobre ContaBancaria;");
    Console.WriteLine("\n* Digite 5 para ver os exercicio sobre Conta;");
    Console.WriteLine("\n* Digite 6 para ver os exercicio sobre CheapShark;");
    Console.WriteLine("\n* Digite 7 para ver os exercicio sobre Carros (End point);");
    Console.WriteLine("\n* Digite 8 para ver os exercicio sobre divisão;");
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
        await ExibirOpcoes();
    }

}

async Task main()
{
    ExibirCabecalho();
    await ExibirOpcoes();
}

main();