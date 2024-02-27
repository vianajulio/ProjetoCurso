namespace ProjetoCurso.Exercicios.Carro;

using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;
using System;
using System.Threading.Tasks;

internal class InteCarro : IMenu
{
    public async Task ExecutarMetodosExercicios()
    {
        CarroInte();
    }
    public static void CarroInte()
    {
        Carro carro = new();
        while (true)
        {
            Console.WriteLine("Digite 1 para Acelerar\nDigite 2 para Freiar\nDigite 3 para buzinar\nDigite 4 para finalizar");
            try
            {
                int Digito = int.Parse(Console.ReadLine() ?? "0");
                if (Digito == 4) break;

                switch (Digito)
                {
                    case 0:
                        Console.WriteLine("Opção invvalida");
                        break;
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
                    default:

                        break;
                }
            }
            catch (Exception ex)
            {
                Menu.ErroInput(ex.ToString());
            }

            void MostrarVelocidade()
            {
                Console.WriteLine($"A velocidade do veiculo é: {carro.VelocidadeReal}");
            }

            Console.ReadKey();
            Console.Clear();

        }
    }
}
