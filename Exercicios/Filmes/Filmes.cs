﻿namespace ProjetoCurso.Exercicios.Filmes;

using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Filmes : IMenu
{
    public async Task ExecutarMetodosExercicios()
    {
        await MostrarDados();
    }
    public static async Task MostrarDados()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string respFilmes = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
                var filmes = JsonSerializer.Deserialize<List<FilmeDesserializer>>(respFilmes);
                filmes!.ForEach(filme => filme.MostarDetalhesFilme());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro {e.Message}");
            }
        }
    }
}