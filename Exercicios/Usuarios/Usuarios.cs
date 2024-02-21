using ProjetoCurso.UIMenu;
using ProjetoCurso;

namespace ProjetoCurso.Exercicios.Usuarios;

class Usuarios : Menu
{
    PessoasAdicionadas pessoasAdicionadas = new PessoasAdicionadas();
    Pessoa pessoa = new Pessoa();
    ManipulacaoDeArquivos arquivos = new ManipulacaoDeArquivos();
    string pathArquivoGerado = "";

    public override async Task ExecutarMetodosExercicios()
    {
        Console.Clear();
        Console.WriteLine("Olá! O que deseja fazer? Digite o número do item");
        Console.WriteLine("0 - Voltar para todos os exercicios...");
        Console.WriteLine("1 - Exibir usuários");
        Console.WriteLine("2 - Adicionar usuários");
        Console.WriteLine("3 - Gerar um arquivo de todos usuários cadastrados");
        Console.WriteLine("4 - Exibir dados do arquivo gerado");

        int opcaoSelecionada = Convert.ToInt32(Console.ReadLine());

        switch (opcaoSelecionada)
        {
            case 1:
                pessoasAdicionadas.ExibirPessoasAdicionadas();
                await BackHome();
                break;
            case 2:
                pessoa.AdicionarPessoa(pessoasAdicionadas);
                await BackHome();
                break;
            case 3:
                pathArquivoGerado = arquivos.GerarArquivoJson(pessoasAdicionadas);
                await BackHome();
                break;
            case 4:
                arquivos.ExibirDados(pathArquivoGerado);
                await BackHome();
                break;
            default:
                Console.Clear();
                break;
        }
    }

    async Task BackHome()
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        Console.ReadKey();
        await ExecutarMetodosExercicios();
    }
}
