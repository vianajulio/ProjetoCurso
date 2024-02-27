using ProjetoCurso.Interfaces;

namespace ProjetoCurso.UIMenu;

internal class LoopMenu
{
    public static async Task LoopMenuExercicios(Dictionary<string, IMenu> opcoes)
    {
        while (true)
        {
            Menu.ExibirCabecalho();
            OpcaoMenu.ExibirOpcoes(opcoes);
            await OpcaoMenu.ExecutarExercicioSelecionado(opcoes);
        }
    }
}
