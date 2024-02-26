﻿using ProjetoCurso.Interfaces;
using ProjetoCurso.UIMenu;
using Petshop.Menus;
using System.Collections.Generic;

namespace ProjetoCurso.Petshop;

internal class PetshopMain : Menu, IMenu
{
 
    public static void MenuMain()
    {
        Dictionary<int, MenuPetshop> opcoes = new();
        opcoes.Add(1, new MenuAgendarConsulta());
        opcoes.Add(2, new MenuExibirArquivos());

        //MenuPetshop.ExibirOpcoes(opcoes);
    }
}