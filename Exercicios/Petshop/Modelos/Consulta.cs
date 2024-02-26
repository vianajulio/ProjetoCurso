namespace Petshop.Modelos;
using Petshop.Menus;

internal class Consulta
{
    public string Horario { get; set; }
    public string TipoDaConsulta { get; set; }
    public string MedicoResponsavel { get; set; }
    public string NomeDoPet{ get; set; }

    public string Duracao;
        
    public Consulta(string horario, string tipoDaConsulta, string medicoResponsavel, string nomeDoPet)
    {
        Horario = horario;
        TipoDaConsulta = tipoDaConsulta;
        MedicoResponsavel = medicoResponsavel;
        NomeDoPet = nomeDoPet;
        Duracao = TipoDaConsulta == "Consulta veterinária de rotina" ? "1 hora"
        : TipoDaConsulta == "Consulta para cuidados de higiene e beleza" ? "1 Hora e 30 Minutos"
        : TipoDaConsulta == "Consulta de nutrição e dieta" ? "30 minutos"
        : TipoDaConsulta == "Consulta comportamental" ? "50 Minutos"
        : "1 Hora e 50 Minutos";
    }

    public void HistoricoDeConsultas(List<Consulta> listaDeConsultas)
    {
        MenuPetshop.DivisaoDeLinhas("-> Histórico de consultas: ");
        foreach (var consulta in listaDeConsultas)
        {
            Console.WriteLine($"* Horario: {consulta.Horario}");
            Console.WriteLine($"* Tipo da consulta: {consulta.TipoDaConsulta}");
            Console.WriteLine($"* Duração: {consulta.Duracao}");
            Console.WriteLine($"* Medico responsável: {consulta.MedicoResponsavel}");
            Console.WriteLine($"* Nome Do Pet: {consulta.NomeDoPet}\n");
        }
    }

    public static string DefinirTipoDaConsulta(Dictionary<int, string> tipoDeConsulta)
    {
        List<KeyValuePair<int, string>> listaDeOpcoes = tipoDeConsulta.ToList();

        string pegaValorSelecionado;
        int tipoDeConsultaSelecionada;

        int count = 0;

        do
        {
            if (count > 0)
            {
                Console.Clear();
                MenuPetshop.ExibirErro("Valor inserido inválido!");
            }

            Console.WriteLine("\n* Informe o tipo da consulta:");
            foreach (var opcao in listaDeOpcoes) Console.WriteLine($"-> Insira {opcao.Key} para {opcao.Value};");
            Console.Write("-> Sua resposta: ");

            tipoDeConsultaSelecionada = int.Parse(Console.ReadLine());
            count += 1;

        } while(!tipoDeConsulta.TryGetValue(tipoDeConsultaSelecionada, out pegaValorSelecionado));
        Console.WriteLine();
        return pegaValorSelecionado;
    }

    public void ExibirInformacoesDaConsulta()
    {
        Console.WriteLine("\nValores da consulta atual: ");
        Console.WriteLine($"* Horário: {Horario}");
        Console.WriteLine($"* Tipo da Consulta: {TipoDaConsulta}");
        Console.WriteLine($"* Duração: {Duracao}");
        Console.WriteLine($"* Médico responsável: {MedicoResponsavel}");
        Console.WriteLine($"* Nome Do Pet: {NomeDoPet}");
    }
}
