namespace Petshop.Modelos;

internal class Dono
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }
    private List<Pet> ListaDePets;

    public Dono(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
        ListaDePets = new List<Pet>();
    }

    public void CadastrarPet(Pet pet)
    {
        ListaDePets.Add(pet);
    }
    public void ExibirListaDePets()
    {
        Console.WriteLine($"\n* {Nome} possui:");
        foreach (var pet in ListaDePets)
        {
            Console.WriteLine($"-> {pet.Nome}");
        }
    }
}
