using System.Text.Json;


namespace ProjetoCurso.Exercicios.Usuarios;

class ManipulacaoDeArquivos
{
   public string arquivoGerado = "";

    public string GerarArquivoJson(PessoasAdicionadas pessoasAdicionadas)
    {
        Console.Clear();
        string json = JsonSerializer.Serialize(new
        {
            pessoasAdicionadas
        });
        Console.Write("Digite o nome que quer colocar em seu arquivo: ");
        string writtenFileName = Console.ReadLine()!;
        string finalFileName = $"{writtenFileName}.json";

        File.WriteAllText(finalFileName, json);

        arquivoGerado = Path.GetFullPath(finalFileName);
        Console.WriteLine($"\nO arquivo Json foi criado com sucesso!\nOnde encontrar: {arquivoGerado}");
        return arquivoGerado;
    }

    public void ExibirDados(string path)
    {
        Console.Clear();
        if (string.IsNullOrEmpty(path))
        {
            Console.WriteLine("Não foi possivel encontrar nenhum arquivo");
        }
        else
        {
            string[] pathArray = path.Split("\\");
            string fileName = pathArray[pathArray.Length - 1];
            Console.WriteLine($"Dados do arquivo: {fileName}");

            string conteudo = "";
            using(StreamReader sr = new StreamReader(fileName))
            {
                string linha;
                while((linha = sr.ReadLine()!) != null)
                {
                    conteudo += linha;
                }
            }

            JsonDocument documento = JsonDocument.Parse(conteudo);

            JsonElement root = documento.RootElement;
            JsonElement listaDePessoas = root.GetProperty("pessoasAdicionadas").GetProperty("ListaDePessoas");

            foreach (JsonElement pessoa in listaDePessoas.EnumerateArray())
            {
                string nome = pessoa.GetProperty("Name").GetString()!;
                string dataNascimento = pessoa.GetProperty("BirthDate").GetString()!;
                int idade = pessoa.GetProperty("Age").GetInt32();
                string email = pessoa.GetProperty("Email").GetString()!;

                Console.WriteLine();
                Console.WriteLine($"Nome: {nome},\nData de Nascimento: {dataNascimento},\nIdade: {idade},\nEmail: {email}");
            }
        }
    }
}
