namespace ProjetoCurso.Exercicios.Oficina;

using ProjetoCurso.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UIMenu;

internal class OficinaAuto : Menu, IMenu
{
    public async Task ExecutarMetodosExercicios()
    {
        await Opcoes();
    }

    async Task Opcoes()
    {
        Console.WriteLine("Olá! O que deseja fazer? Digite o número do item");
        Console.WriteLine("0 - Voltar para todos os exercicios..");
        Console.WriteLine("1 - Cadastrar ficha");
        Console.WriteLine("2 - Exibir fichas");

        int opcaoSelecionada = Convert.ToInt32(Console.ReadLine());
        switch (opcaoSelecionada) 
        {
            case 1:
                Console.Clear();
                CadastrarFicha();
                Console.Clear();
                await Opcoes();
                break;
            case 2:
                Console.Clear();
                MostrarFicha();
                await voltar();
                break;
            default:
                Console.Clear();
                break;
        }
    }
    async Task voltar()
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        Console.ReadKey();
        await ExecutarMetodosExercicios();
    }

    public List<string> problemas = new List<string>
    {
        "Problema na junta do motor;",
        "Problema no amortecedor;",
        "Problema de pneu furado;",
        "Problema na homocinetica;",
        "Problema na lataria;"
    };

    public List<VeiculoOficina> veiculosManutencao = new List<VeiculoOficina> { };

    private void MostrarFicha()
    {
        veiculosManutencao.ForEach(veiculo => veiculo.mostrarDados());
    }

    private void CadastrarFicha()
    {
        Console.WriteLine("Digite o nome, modelo e ano do veiculo: ");
        string veiculo = Console.ReadLine() ?? "SEM NOME";
        Console.WriteLine("Digite o nome do mecânico responsavel pelo reparo: ");
        string responsavel = Console.ReadLine() ?? "SEM NOME";
        Console.WriteLine("Digite o valor cotado para o reparo: ");
        double valorReparo = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Selecione um dos problemas listados: ");
        for (int i = 0; i < problemas.Count; i++)
        {
            Console.WriteLine($"{i} - {problemas[i]}");
        }
        
        Console.Write("\nOpção: ");
        int numProblema = int.Parse(Console.ReadLine() ?? "0");

        string problemaVeiculo = problemas[numProblema];
        VeiculoOficina veiculoManutencao = new VeiculoOficina(veiculo, responsavel, valorReparo, problemaVeiculo);
        veiculosManutencao.Add(veiculoManutencao); 
    }

}
