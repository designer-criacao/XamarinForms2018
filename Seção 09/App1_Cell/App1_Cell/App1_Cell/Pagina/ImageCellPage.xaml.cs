﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Cell.Modelo;

namespace App1_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();
            //
            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto = "perfil1.png", Nome = "José", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Foto = "perfil1.png", Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Foto = "perfil1.png", Nome = "Elaine", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Foto = "perfil1.png", Nome = "Victor", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Foto = "perfil1.png", Nome = "João", Cargo = "Vendedor" });

            ListaDeFuncionario.ItemsSource = Lista;

        }
    }
}