
using ProjetoCurso.Exercicios.FormasGeometricas;

internal class Triangulo : FormaGeometrica
{
    public Triangulo(float largura) : base(largura)
    {
        Largura = largura;
    }

    public float Largura { get; set; }

    public override void CalculaArea()
    {
        Console.WriteLine(Largura * Largura / 2);
    }

    public override void CalculaPerimetro()
    {
        Console.WriteLine(Largura * 3);
    }

}
