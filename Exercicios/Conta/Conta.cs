namespace ProjetoCurso.Exercicios.Conta;

using ProjetoCurso.UI;

internal class Conta : UIMenu
{
    private string Titular;
    private float Saldo;

    public override async Task Executar()
    {
        await base.Executar();
        ExibirTituloDoExercicio("Exercício sobre Conta");
        MostrarDados();
    }

    public Conta(string titular, float saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Titular: {Titular} \nSaldo: {Saldo}");
    }

    public override string NomeUI()
    {
        return "Conta Simples";
    }

}
