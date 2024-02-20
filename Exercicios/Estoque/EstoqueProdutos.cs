﻿namespace ProjetoCurso.Exercicios.Estoque;
using ProjetoCurso.UI;
using System;
using System.Numerics;

internal class EstoqueProdutos : UIMenu
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }    

    public override async Task Executar()
    {
        await base.Executar();
        ExibirTituloDoExercicio("Exercício sobre Conta Bancaria");
        CadastrarProdutos();
        MostrarProdutos();
    }

    public void CadastrarProdutos()
    {
        Console.WriteLine("Digite um produto para ser cadastrado: ");
        Nome = Console.ReadLine() ?? "Produto invalido";
        Console.WriteLine("Entre com a quantidade de estoque do produto: ");
        Quantidade = int.Parse(Console.ReadLine() ?? "0");

    } 
    public void MostrarProdutos()
    {
        Console.WriteLine($"\nProduto cadastrado: {Nome}\nQuantidade em estoque: {Quantidade}\n");
    }

    public override string NomeUI()
    {
        return "Estoque de produtos";
    }
}