namespace ProjetoCurso.Exercicios.Oficina;

using System;
using System.Threading.Channels;
using UI;

internal class OficinaAuto : UIMenu
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

    public override async Task Executar()
    {
        await base.Executar();
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
        string veiculo = Console.ReadLine();
        Console.WriteLine("Digite o nome do mecânico responsavel pelo reparo: ");
        string responsavel = Console.ReadLine();
        Console.WriteLine("Digite o valor cotado para o reparo: ");
        double valorReparo = double.Parse(Console.ReadLine());
        Console.WriteLine("Selecione um dos problemas listados: ");
        for (int i = 0; i < problemas.Count; i++)
        {
            Console.WriteLine($"{i} - {problemas[i]}");
        }
        Console.Write("\nOpção: ");
        int problema = int.Parse(Console.ReadLine());

        string problemaVeiculo = problemas[problema];
        VeiculoOficina veiculoManutencao = new VeiculoOficina(veiculo, responsavel, valorReparo, problemaVeiculo);
        veiculosManutencao.Add(veiculoManutencao);
    }

}
