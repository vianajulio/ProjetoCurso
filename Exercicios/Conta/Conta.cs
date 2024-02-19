﻿namespace ProjetoCurso.Exercicios.Conta;
using UIMenu;
internal class Conta : UIMenu
{
    private string Titular;
    private float Saldo;

    public override async Task Executar()
    {
        base.Executar();
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
}
