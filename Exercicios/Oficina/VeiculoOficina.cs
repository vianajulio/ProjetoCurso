namespace ProjetoCurso.Exercicios.Oficina;

internal class VeiculoOficina
{
    public string Veiculo { get; set; }
    public string Responsavel { get; set; }
    public double ValorReparo { get; set; }
    public string ProblemaVeiculo { get; set; }

    public VeiculoOficina(string veiculo, string responsavel, double valorReparo, string problemaVeiculo)
    {
        Veiculo = veiculo;
        Responsavel = responsavel;
        ValorReparo = valorReparo;
        ProblemaVeiculo = problemaVeiculo;
    }
}
