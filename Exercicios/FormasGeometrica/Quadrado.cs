
using ProjetoCurso.Exercicios.FormasGeometricas;

internal class Quadrado : FormaGeometrica
{
    public float Largura { get; set; }

    public Quadrado(float largura) : base(largura)
    {
        Largura = largura;
    }

    public override void CalculaArea()
    {
        Console.WriteLine(Largura * Largura);
    }
    public override void CalculaPerimetro()
    {
        Console.WriteLine(Largura * 4);
    }
}
