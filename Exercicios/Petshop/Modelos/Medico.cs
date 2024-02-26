namespace Petshop.Modelos;

internal class Medico
{
    public string Nome { get; set; }
    private DateTime DataDeNascimento {get; set;}
    private string Cpf { get; set;}
    private double Salario { get; set;}

    public Medico(string nome, DateTime dataDeNascimento, string cpf, double salario)
    {
        Nome = nome;
        DataDeNascimento = dataDeNascimento;
        Cpf = cpf;
        Salario = salario;
    }
    public void ExibirInformacoesMedico()
    {
        Console.WriteLine($"\n* Segue as informações do médico {Nome}: ");
        Console.WriteLine($"-> Nome: {Nome}: ");
        Console.WriteLine($"-> Data de Nascimento: {DataDeNascimento}: ");
        Console.WriteLine($"-> CPF: {Cpf}: ");
        Console.WriteLine($"-> Salário: {Salario}: ");
    }
}
