namespace ProjetoCurso.Exercicios.Conta;

using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;
using System;
using System.Threading.Tasks;

internal class Conta : IMenu
{
    public async Task ExecutarMetodosExercicios()
    {
        RetornaContaAleatoria().MostrarDados();
    }

    private Conta RetornaContaAleatoria()
    {
        List<string> titulares = new List<string> { "Julio", "Cainã", "Rafael", "Murilo" };
        Random rdn = new Random();
        float saldo = rdn.Next(10, 10000) / 2;
        Conta conta = new Conta(titulares[0], saldo);
        return conta;
    }

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
