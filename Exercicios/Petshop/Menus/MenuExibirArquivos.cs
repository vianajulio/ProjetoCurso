
using Newtonsoft.Json;
using Petshop.Modelos;

namespace Petshop.Menus;

internal class MenuExibirArquivos : MenuPetshop
{
    public override void ExecutarMetodosDosMenus()
    {
        base.ExecutarMetodosDosMenus();
        ExibirTitulo("Exibir dados do arquivo");
        ExibirInformacoesArquivoConsultas();
    }
    public static void ExibirInformacoesArquivoConsultas()
    {
        Console.Write("Qual o nome do arquivo que deseja visualizar?\n -> Sua Resposta: ");
        string nomeDoArquivo = Console.ReadLine();
        try
        {
            if (!File.Exists(nomeDoArquivo))
            {
                ExibirErro("Arquivo não foi encontrado!");
                return;
            }

            string jsonContent = File.ReadAllText(nomeDoArquivo);
            var consultas = JsonConvert.DeserializeObject<Consulta[]>(jsonContent);
            Console.WriteLine("\n.Os dados do arquivo são:");
            foreach (var consulta in consultas)
            {
                Console.WriteLine($"  * Horário: {consulta.Horario}");
                Console.WriteLine($"  * Tipo de Consulta: {consulta.TipoDaConsulta}");
                Console.WriteLine($"  * Médico Responsável: {consulta.MedicoResponsavel}");
                Console.WriteLine($"  * Nome do Pet: {consulta.NomeDoPet}");
                Console.WriteLine($"  * Duração: {consulta.Duracao}\n");
            }

            
        }
        catch( Exception error ) 
        {
            ExibirErro(error.Message);
        }
    }
}
