using ProjetoCurso.UIMenu;
using System;
using System.Threading.Tasks;

namespace ProjetoCurso.Exercicios.Divisao;

internal class Divisao : Menu
{
    public new async Task ExecutarMetodosExercicios()
    {
        await base.ExecutarMetodosExercicios();
        ExibirTituloDoExercicio("Exercício sobre Divisão");
        MostrarDivisao();
    }
    public static void MostrarDivisao()
    {
        Console.WriteLine("Atividade de divisão\n");
        Console.Out.WriteLine("Digite um valor: ");
        int valor1 = int.Parse(Console.ReadLine()!);
        Console.Out.WriteLine("Digite outro valor: ");
        int valor2 = int.Parse(Console.ReadLine()!);
        try
        {
            int resultado = valor1 / valor2;

            Console.Out.WriteLine($"O Resultado é: {resultado}");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.Out.WriteLine($"Ocorreu um erro durante a divisão: {ex.Message}");
            Console.ReadKey();
        }
    }
}
