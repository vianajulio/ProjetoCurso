using System.Text.Json;

namespace ProjetoCurso.Exercicios.Usuarios
{
    internal class ManipulacaoDeArquivos
    {
        public string arquivoGerado = "";

        public void GerarArquivoJson(PessoasAdicionadas pessoasAdicionadas)
        {
            Console.Clear();
            string json = JsonSerializer.Serialize(new
            {
                pessoasAdicionadas
            });
            string nomeDoArquivo = $"pessoasCadastradas.json";

            File.WriteAllText(nomeDoArquivo, json);

            arquivoGerado = Path.GetFullPath(nomeDoArquivo);
            Console.WriteLine($"O arquivo Json foi criado com sucesso!\nOnde encontrar: {arquivoGerado}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }
    }
}
