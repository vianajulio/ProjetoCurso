namespace ProjetoCurso.Exercicios.Oficina;

using ProjetoCurso.Interfaces;
using System;
using UIMenu;

internal class OficinaAuto : Menu, InterfaceMenu
{

    public List<string> problemas = new List<string>
    {
        "Problema na junta do motor;",
        "Problema no amortecedor;",
        "Problema de pneu furado;",
        "Problema na homocinetica;",
        "Problema na lataria;"
    };

    public List<VeiculoOficina> veiculosManutencao = new List<VeiculoOficina>
    {
    };

    public override async Task ExecutarMetodosExercicios()
    {
        await base.ExecutarMetodosExercicios();
        ExibirTituloDoExercicio("Exercício sobre Conta Bancaria");
        CadastrarFicha();
        MostrarFicha();
        Console.ReadKey();
    }

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
