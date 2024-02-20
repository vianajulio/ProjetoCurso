
using ProjetoCurso.Exercicios.FormasGeometricas;

internal class Circulo : FormaGeometrica
{
    public Circulo(float tamanho) : base(tamanho)
    {
        Largura = tamanho;
    }
    private float Largura { get; set; }

    public override void CalculaArea()
    {
        Console.WriteLine(3.14 * Math.Pow((Largura / 2), 2));
    }
    public override void CalculaPerimetro()
    {
        Console.WriteLine(2 * 3.14 * (Largura / 2));
    }
}
