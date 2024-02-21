namespace ProjetoCurso.Exercicios.Oficina;
using System;
using UI;

internal class OficinaAuto : UIMenu
{
    public override async Task ExecutarMetodosExercicios()
    {
        await base.ExecutarMetodosExercicios();
        ExibirTituloDoExercicio("Exercício sobre Oficina mecânica de autos");
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

    public List<VeiculoOficina> veiculosManutencao = new List<VeiculoOficina>
    {
    };

    private void MostrarFicha()
    {
        veiculosManutencao.ForEach(veiculo => veiculo.mostrarDados());
    }

    private void CadastrarFicha()
    {
        Console.WriteLine("Digite a marca do veiculo, modelo e ano: ");
        string veiculo = Console.ReadLine();
        Console.WriteLine("Digite o nome do mecânico responsavel pelo reparo: ");
        string responsavel = Console.ReadLine();
        Console.WriteLine("Digite o valor cotado para o reparo: ");
        double valorReparo = double.Parse(Console.ReadLine());
        Console.Clear();
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
