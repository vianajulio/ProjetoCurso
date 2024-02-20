﻿namespace ProjetoCurso.Exercicios.Carro;

using ProjetoCurso.Interfaces;
using ProjetoCurso.UI;

internal class InteCarro : UIMenu
{
    public override async Task Executar()
    {
        await base.Executar();
        ExibirTituloDoExercicio("Exercício sobre Carro");
        CarroInte();
    }
    public static void CarroInte()
    {
        Carro carro = new();
        while (true)
        {
            Console.WriteLine("Digite 1 para Acelerar\nDigite 2 para Freiar\nDigite 3 para buzinar\nDigite 4 para finalizar");
            int Digito = int.Parse(Console.ReadLine() ?? "0");

            void MostrarVelocidade()
            {
                Console.WriteLine($"A velocidade do veiculo é: {carro.VelocidadeReal}");
            }

            if (Digito == 4) break;

            switch (Digito)
            {
                case 1:
                    carro.Acelerar();
                    MostrarVelocidade();
                    break;
                case 2:
                    Console.Write("Digite a pressão desejada: ");
                    int pressao = int.Parse(Console.ReadLine() ?? "0");
                    carro.Frear(pressao);
                    MostrarVelocidade();
                    break;
                case 3:
                    carro.Buzinar();
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
    public override string NomeUI()
    {
        return "Carro";
    }
}
