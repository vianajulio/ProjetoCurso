namespace ProjetoCurso.Exercicios.Carro;

using ProjetoCurso.UIMenu;

internal class Carro : UIMenu
{
    public override void Executar()
    {
        base.Executar();
        ExibirTituloDoExercicio("Exercício sobre carro - 01");
        ConfirmarEntrada();
    }
    void ConfirmarEntrada()
    {
        Console.WriteLine("Entrou na classe Carro");
    }
}
