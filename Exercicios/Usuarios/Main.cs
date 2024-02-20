namespace ProjetoCurso.Exercicios.Usuarios
{
    internal class Main
    {
        PessoasAdicionadas pessoasAdicionadas = new PessoasAdicionadas();
        Pessoa pessoa = new Pessoa();
        ManipulacaoDeArquivos arquivos = new ManipulacaoDeArquivos();

        void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Olá! O que deseja fazer? Digite o número do item");
            Console.WriteLine("1 - Exibir usuários");
            Console.WriteLine("2 - Adicionar usuários");
            Console.WriteLine("3 - Gerar um arquivo de todos usuários cadastrados");
            Console.WriteLine("4 - Gerar um arquivo de um usuário cadastrados por email");
            Console.WriteLine("5 - Exibir dados do arquivo gerado");

            int opcaoSelecionada = Convert.ToInt32(Console.ReadLine());

            switch (opcaoSelecionada)
            {
                case 1:
                    pessoasAdicionadas.ExibirPessoasAdicionadas();
                    MainMenu();
                    break;
                case 2:
                    pessoa.AdicionarPessoa(pessoasAdicionadas);
                    MainMenu();
                    break;
                case 3:
                    arquivos.GerarArquivoJson(pessoasAdicionadas);
                    MainMenu();
                    break;
            }
        }
    }
}
