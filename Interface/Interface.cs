namespace ProjetoCurso.UIMenu;

internal class UIMenu
{
    public void ExibirTituloDoExercicio(string titulo)
    {
        int tamanhoTitulo = titulo.Length;
        string asteriscos = string.Empty.PadLeft(tamanhoTitulo, '*');
        Console.WriteLine(asteriscos+ "****");
        Console.WriteLine("* " + titulo + " *");
        Console.WriteLine(asteriscos+"****" + "\n");
    }
   public virtual async Task Executar()
    {
        Console.Clear();
    }
}
