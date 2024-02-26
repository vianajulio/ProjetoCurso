﻿namespace ProjetoCurso.Exercicios.ContaBancaria;

using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;
using System;
using System.Threading.Tasks;

internal class ContaBancaria : Menu, IMenu
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

    public new async Task ExecutarMetodosExercicios()
    {
        await base.ExecutarMetodosExercicios();
        MostrarDados();
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Indicador: {Indicador}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");
    }
}