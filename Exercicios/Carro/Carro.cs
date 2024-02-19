namespace ProjetoCurso.Exercicios.Carro;
internal class Carro
{
    private int Velocidade { get; set; }

    public int VelocidadeReal
    {
        get
        {
            return Velocidade;
        }
    }
    public void Acelerar()
    {
        this.Velocidade += 10;
    }

    public void Frear(int Pressao)
    {
        this.Velocidade -= (this.Velocidade < (Pressao * 10) ? Velocidade : (Pressao * 10));
    }

    public void Buzinar()
    {
        Console.Beep();
    }
}


