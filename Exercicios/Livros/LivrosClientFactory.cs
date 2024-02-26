using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ProjetoCurso.Exercicios.Livros;

<<<<<<< HEAD
public class LivrosClientFactory 
    //: IHttpClientFactory
=======
public class LivrosClientFactory
>>>>>>> 824ac97dd50d85f2e8cc8a03c43052d9eb0bb8a7
{
    private string url = "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/";
    public HttpClient CreateClient(string name)
    {
        HttpClient _client = new HttpClient();
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        _client.BaseAddress = new Uri(url);
        return _client;
    }
}
