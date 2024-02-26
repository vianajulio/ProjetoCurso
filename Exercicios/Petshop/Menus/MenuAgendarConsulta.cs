namespace Petshop.Menus;
using Petshop.Modelos;
using System.Text.Json;

internal class MenuAgendarConsulta : MenuPetshop
{
    private List<Consulta> listaDeConsultas;
    public override void ExecutarMetodosDosMenus()
    {
        base.ExecutarMetodosDosMenus();
        listaDeConsultas = new List<Consulta>();
        ExibirTitulo("Agendar Consultas");
        AgendarConsulta();
    }

    public void AgendarConsulta()
    {
        do
        {
            Console.Clear();
            Dictionary<int, string> tiposDeConsulta = new Dictionary<int, string>();
            tiposDeConsulta.Add(1, "Consulta veterinária de rotina");
            tiposDeConsulta.Add(2, "Consulta para cuidados de higiene e beleza");
            tiposDeConsulta.Add(3, "Consulta de nutrição e dieta");
            tiposDeConsulta.Add(4, "Consulta comportamental");
            tiposDeConsulta.Add(5, "Consulta para cuidados de saúde específicos");

            Console.Write("Informe o horário da consulta: ");
            string horario = Console.ReadLine();
            string tipoSelecionado = Consulta.DefinirTipoDaConsulta(tiposDeConsulta);
            Console.Write("Informa o nome do Médico responsável: ");
            string medicoResponsavel = Console.ReadLine();
            Console.Write("Informa o nome do pet que será atendido: ");
            string nomeDoPet = Console.ReadLine();

            Consulta consulta = new Consulta(horario, tipoSelecionado, medicoResponsavel, nomeDoPet);
            consulta.ExibirInformacoesDaConsulta();

            listaDeConsultas.Add(consulta);
            consulta.HistoricoDeConsultas(listaDeConsultas);
        } while (TratandoRespostaBooleana("Deseja agendar outra consulta?"));
        
        if (TratandoRespostaBooleana("Deseja salvar o progresso em um arquivo (Caso não, o seu hostórico será perdido)?"))
        {
            RegistrarInformacoes(listaDeConsultas, "ConsultasRegistradas");
        }
    }
}
