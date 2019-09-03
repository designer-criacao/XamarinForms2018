using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarefa.Modelos;

namespace Tarefa.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        private byte Prioridade { get; set; }
        public Cadastro()
        {
            InitializeComponent();
        }

        private void PrioridadeSelectAction(object sender, EventArgs e)
        {
            var Stacks = SLPrioridades.Children;

            foreach(var Linha in Stacks)
            {
                Label LblPrioridade = ((StackLayout)Linha).Children[1] as Label;
                LblPrioridade.TextColor = Color.Gray;
            }

            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource Source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;

            String Prioridade = Source.File.ToString().Replace("img","").Replace(".png", "");
            //TxtNome.Text = Prioridade;
            this.Prioridade =  byte.Parse(Prioridade);

        }

        private void SalvarAction(object sender, EventArgs e)
        {
            bool ErroExiste = false;
            if(!(TxtNome.Text.Trim().Length > 0))
            {
                ErroExiste = true;
                DisplayAlert("Erro", "Nome não preenchido!", "OK");
            }

            if(!(this.Prioridade > 0))
            {
                ErroExiste = true;
                DisplayAlert("Erro", "Prioridade não foi informada!", "OK");
            }

            if(ErroExiste == false)
            {
                //Salva esses dados...
                Tarefas tarefas = new Tarefas();
                tarefas.Nome = TxtNome.Text.Trim();
                tarefas.Prioridade = this.Prioridade;

                new GerenciadorTarefa().Salvar(tarefas);

                App.Current.MainPage = new NavigationPage(new Inicio());

                //TxtNome.Text = new GerenciadorTarefa().Listagem().Count.ToString();
            }
        }
    }
}