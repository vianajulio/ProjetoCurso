﻿using ProjetoCurso.Exercicios.Carro;
using ProjetoCurso.Exercicios.CheapShark;
using ProjetoCurso.Exercicios.Conta;
using ProjetoCurso.Exercicios.ContaBancaria;
using ProjetoCurso.Exercicios.Filmes;
using ProjetoCurso.Exercicios.Livros;
using ProjetoCurso.Exercicios.Paises;
using ProjetoCurso.UIMenu;
using ProjetoCurso.Exercicios.Oficina;
using ProjetoCurso.Exercicios.Usuarios;
using ProjetoCurso.Exercicios.Calculadora;
using ProjetoCurso.Petshop;
using System.Threading.Tasks;
using System.Collections.Generic;
using ProjetoCurso.Interfaces;

namespace ProjetoCurso;
class Program
{
    public static async Task Main(string[] args)
    {
        Dictionary<string, IMenu> opcoes = new();
        opcoes.Add("Carro", new InteCarro());
        opcoes.Add("Calculadora", new Calculadora());
        opcoes.Add("Conta", new Conta("Fraga", 100));
        opcoes.Add("Usuarios", new Usuarios());
        opcoes.Add("Oficina", new OficinaAuto());
        opcoes.Add("Conta Bancaria", new ContaBancaria(1, "Fraga", 100, 123));
        opcoes.Add("Filmes HTPP Request", new Filmes());
        opcoes.Add("Cheap Shark HTPP Request", new CheapSharkHttpClient());
        opcoes.Add("Livros HTPP Request", new LivrosHttpClient(new LivrosClientFactory().CreateClient("Livros")));
        opcoes.Add("Pais HTPP Request", new PaisMain());
        opcoes.Add("Petshop", new PetshopMain());

        await LoopMenu.LoopMenuExercicios(opcoes);
    }
}