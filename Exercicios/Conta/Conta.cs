namespace ProjetoCurso.Exercicios.Conta;

internal class Conta
{
    private string Titular;
    private float Saldo;

    public Conta(string titular, float saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Titular: {Titular} \nSaldo: {Saldo}");
    }
}
