namespace ProjetoCurso.Exercicios.Estoque;
using ProjetoCurso.UIMenu;

internal class EstoqueProdutos : Menu
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }    

    public override async Task ExecutarMetodosExercicios()
    {
        await base.ExecutarMetodosExercicios();
        ExibirTituloDoExercicio("Exercício sobre Conta Bancaria");
        CadastrarProdutos();
        MostrarProdutos();
    }

    public void CadastrarProdutos()
    {
        Console.WriteLine("Digite um produto para ser cadastrado: ");
        Nome = Console.ReadLine() ?? "Produto invalido";
        Console.WriteLine("Entre com a quantidade de estoque do produto: ");
        Quantidade = int.Parse(Console.ReadLine() ?? "0");

    } 
    public void MostrarProdutos()
    {
        Console.WriteLine($"\nProduto cadastrado: {Nome}\nQuantidade em estoque: {Quantidade}\n");
    }
}
