namespace ProjetoCurso.Exercicios.Conta;

using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;
using System;
using System.Threading.Tasks;

internal class Conta : Menu, IMenu
{
    public override async Task ExecutarMetodosExercicios()
    {
        await base.ExecutarMetodosExercicios();
        ExibirTituloDoExercicio("Exercício sobre Conta");

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
