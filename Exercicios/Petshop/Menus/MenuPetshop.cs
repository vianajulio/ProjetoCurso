using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Petshop.Menus;

internal class MenuPetshop
{
    public virtual void ExecutarMetodosDosMenus()
    {
        Console.Clear();
    }
    public static void ExibirTitulo(string titulo)
    {
        int tamanhoTitulo = titulo.Length;
        string asteriscos = string.Empty.PadLeft(tamanhoTitulo, '*');
        Console.WriteLine(asteriscos + "****");
        Console.WriteLine("* " + titulo + " *");
        Console.WriteLine(asteriscos + "****" + "\n");
    }
    public static void DivisaoDeLinhas(string texto)
    {
        int tmnDoTexto = texto.Length;
        string divisor = string.Empty.PadLeft(tmnDoTexto, '-');
        Console.WriteLine($"\n\n{divisor}\n");
        Console.WriteLine(texto);
    }
    public static void ExibirCabecalho()
    {
        Console.WriteLine("Bem vindo ao sistema de petshop!\n");
    }
    public static void ExibirErro(string mensagem)
    {
        Console.WriteLine($"OPS! Algo deu errado.\n{mensagem}");
    }
    public static void ExibirOpcoes(Dictionary<int, MenuPetshop> opcoes)
    {
        while (true)
        {
            int numeroOpcaoConvertido;
            int count = 0;
            do
            {
                if (count > 0)
                {
                    Console.Clear();
                    ExibirErro("Numero inserido inválido!\nTente Novamente.\n");
                }
                ExibirCabecalho();

                Console.WriteLine("* Digite -1 para encerrar o programa;");
                Console.WriteLine("* Digite 0 para voltar ao menu dos exercícios e pressione em qualquer tecla duas vezes;");
                Console.WriteLine("* Digite 1 agendar uma consulta;");
                Console.WriteLine("* Digite 2 ver os dados de um arquivo;");
                Console.Write("-> Sua resposta: ");
                string numeroInserido = Console.ReadLine();
                numeroOpcaoConvertido = int.Parse(numeroInserido);

                count += 1;

            } while (numeroOpcaoConvertido < -1 || numeroOpcaoConvertido > opcoes.Count);

            if (numeroOpcaoConvertido == -1) Environment.Exit(0);
            if (numeroOpcaoConvertido == 0) break;

            MenuPetshop opcaoSelecionada = opcoes[numeroOpcaoConvertido];
            opcaoSelecionada.ExecutarMetodosDosMenus();

            Console.Write("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
    public static void RegistrarInformacoes<T>(List<T> listaDoRegistro, string nomeDoArquivo)
    {
        string caminhoDoArquivo = $"{nomeDoArquivo}.json";
        string json = JsonSerializer.Serialize(listaDoRegistro);
        try
        {
            File.WriteAllText(caminhoDoArquivo, json);
            Console.WriteLine($"\nArquivo: {nomeDoArquivo}, Salvo com sucesso!");
        }
        catch (Exception error)
        {
            MenuPetshop.ExibirErro(error.Message);
        }
    }
    public static bool TratandoRespostaBooleana(string perguntaASerFeita)
    {
        while (true)
        {
            Console.Write($"\n{perguntaASerFeita} (S/N) -> ");
            string resposta = Console.ReadLine();
            if (resposta.ToUpper() == "S")
            {
                return true;
            }
            else if (resposta.ToUpper() == "N")
            {
                return false;
            }
            else
            {
                Console.Clear();
                ExibirErro("Utilize apenas 'S' ou 'N' para responder!");
            }

        }
    }
}
