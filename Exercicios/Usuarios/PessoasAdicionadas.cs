namespace ProjetoCurso.Exercicios.Usuarios;

class PessoasAdicionadas
{
    public List<Pessoa> ListaDePessoas { get; }

    public PessoasAdicionadas()
    {
        ListaDePessoas = new List<Pessoa>();
    }

    public void AdicionarPessoa(Pessoa pessoa)
    {
        ListaDePessoas.Add(pessoa);
    }

    public void ExibirPessoasAdicionadas()
    {
        Console.Clear();
        Console.WriteLine("Usuários adicionados:");
        Console.WriteLine($"Quantidade de pessoas: {ListaDePessoas.Count().ToString()}");
        ListaDePessoas.ForEach(pessoa =>
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {pessoa.Name}");
            Console.WriteLine($"BirthDate: {pessoa.BirthDate}");
            Console.WriteLine($"Age: {pessoa.Age}");
            Console.WriteLine($"Email: {pessoa.Email}");
        });
    }
}