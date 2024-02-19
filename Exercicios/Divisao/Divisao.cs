namespace ProjetoCurso.Exercicios.Divisao;
using UIMenu;
internal class Divisao : UIMenu
{
    public override async Task Executar()
    {
        base.Executar();
        ExibirTituloDoExercicio("Exercício sobre Divisão");
        MostrarDivisao();
    }
    public static async Task MostrarDivisao()
    {
        await Console.Out.WriteLineAsync("Atividade de divisão\n");

        await Console.Out.WriteLineAsync("Digite um valor: ");
        int valor1 = int.Parse(Console.ReadLine());
        await Console.Out.WriteLineAsync("Digite outro valor: ");
        int valor2 = int.Parse(Console.ReadLine());
        try
        {
            int resultado = valor1 / valor2;

            await Console.Out.WriteLineAsync($"O Resultado é: {resultado}");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync($"Ocorreu um erro durante a divisão: {ex.Message}");
            Console.ReadKey();
        }
        //if (valor2 == null)
        //{
        //    await Console.Out.WriteLineAsync($"Não é possivel Dividir {valor1} por 0! Entre com outro numero inteiro.");
        //    valor2 = Console.Read();
        //}
        //else
        //{ }
    }
}
