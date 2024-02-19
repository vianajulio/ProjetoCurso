namespace ProjetoCurso.Exercicios.ContaBancaria;
using UIMenu;
internal class ContaBancaria : UIMenu
{
    public override async Task Executar()
    {
        base.Executar();
        ExibirTituloDoExercicio("Exercício sobre ContaBancaria");
        MostrarDados();
    }

    public int Indicador { get; }
    private string Titular { get; }
    private float Saldo { get; }
    public int Senha { get; }

    public ContaBancaria(int indicador, string titular, float saldo, int senha)
    {
        Indicador = indicador;
        Titular = titular;
        Saldo = saldo;
        Senha = senha;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Indicador: {Indicador}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");
    }
}