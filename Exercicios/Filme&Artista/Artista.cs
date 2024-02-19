namespace ProjetoCurso.Exercicios.Filme_Artista;

internal class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    private List<Filme> _filmesParticipados = new List<Filme>();

    public List<Filme> FilmesParticipados
    {
        get { return _filmesParticipados; }
        set { _filmesParticipados = value; }
    }
}
