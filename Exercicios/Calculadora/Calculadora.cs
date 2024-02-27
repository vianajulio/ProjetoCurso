using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;
using System;
using System.Threading.Tasks;

namespace ProjetoCurso.Exercicios.Calculadora;

internal class Calculadora : IMenu
{
    public async Task ExecutarMetodosExercicios()
    {
        Console.WriteLine("Somar");
    }

    public void Somar(int numA, int numB)
    {
        Console.WriteLine(numA + numB);
    }

    public void Subtrair(int numA, int numB)
    {
        Console.WriteLine(numA - numB);
    }

    public void Multiplicar(int numA, int numB)
    {
        Console.WriteLine(numA * numB);
    }

    public void Dividir(int numA, int numB)
    {
        if (numA != 0 && numB != 0)
        {
            Console.WriteLine(numA / numB);
        }
        else
        {
            Console.WriteLine("Valores inválidos!");
        }
    }

    public void RaizQuadrada(int numA)
    {
        Console.WriteLine(Math.Sqrt(numA));
    }
    public void Potencia(int numA, int numB)
    {
        Console.WriteLine(Math.Pow(numA, numB));
    }

}
