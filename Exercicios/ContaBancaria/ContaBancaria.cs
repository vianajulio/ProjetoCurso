namespace ProjetoCurso.Exercicios.ContaBancaria;


using ProjetoCurso.UI;

internal class ContaBancaria : UIMenu
{
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

    public override async Task Executar()
    {
        await base.Executar();
        ExibirTituloDoExercicio("Exercício sobre Conta Bancaria");
        MostrarDados();
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Indicador: {Indicador}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");
    }

    public override string NomeUI()
    {
        return "Conta Bancária";
    }
}