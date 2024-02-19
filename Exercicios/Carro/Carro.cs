namespace ProjetoCurso.Exercicios.Carro;
using ProjetoCurso.UIMenu;
internal class Carro : UIMenu
{
    private int Velocidade { get; set; }

    public int VelocidadeReal
    {
        get
        {
            return Velocidade;
        }
    }
    public override void Executar()
    {
        base.Executar();
        ExibirTituloDoExercicio("Exercício sobre Carro");
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


