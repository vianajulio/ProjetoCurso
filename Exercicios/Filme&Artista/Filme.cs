namespace ProjetoCurso.Exercicios.Filme_Artista;

internal class Filme
{
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    private List<Artista> _elenco = new List<Artista>();

    public List<Artista> Elenco
    {
        get
        {
            return _elenco;
        }
        set
        {
            _elenco = value;
            foreach (var artista in _elenco)
            {
                artista.FilmesParticipados.Add(this);
            }

        }
    }
}