namespace ProjetoCurso.Exercicios.Usuarios;


class Pessoa
{
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age
    {
        get
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;

            return BirthDate.Date > today.AddYears(-age) ? age - 1 : age;
        }
    }
    public string? Email { get; set; }


    public void AdicionarPessoa(PessoasAdicionadas pessoas)
    {
        Console.Clear();
        Console.Write("Digite seu nome: ");
        string name = Console.ReadLine()!;

        Console.Write("Digite sua data de nascimento: ");
        DateTime birthDate = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", null);

        Console.Write("Digite seu email: ");
        string email = Console.ReadLine()!;
        Pessoa pessoa = new Pessoa();

        pessoa.Name = name;
        pessoa.BirthDate = birthDate;
        pessoa.Email = email;

        pessoas.AdicionarPessoa(pessoa);
    }

    public void ExibirPessoaAdicionada()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"BirthDate: {BirthDate}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine();
    }
}
