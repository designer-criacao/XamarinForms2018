using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarefa.Modelos;

namespace Tarefa.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();

            CultureInfo culture = new CultureInfo("pt-BR");
            string Data = DateTime.Now.ToString("dddd, dd {0} MMMM {0} yyyy", culture);
            DataHoje.Text = string.Format(Data, "de");
            //DataHoje.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToString("dd/MM");

            CarregarTarefas();
        }

        private void ActionGoCadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }

        private void CarregarTarefas()
        {
            SLTarefas.Children.Clear();

            List<Tarefas> Lista = new GerenciadorTarefa().Listagem();

            int i = 0;
            foreach(Tarefas tarefas in Lista)
            {
                LinhaStackLayout(tarefas, i);
                i++;
            }

        }

        public void LinhaStackLayout(Tarefas tarefas, int index)
        {
            //Imagem de Deletar
            Image Delete = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("delete.png"), WidthRequest = 30, HeightRequest = 30 };
            /*if(Device.RuntimePlatform == Device.Windows)
            {
                Delete.Source = ImageSource.FromFile("Caminhodapasta/delete.png");
            }*/
            TapGestureRecognizer DeleteTap = new TapGestureRecognizer();
            DeleteTap.Tapped += delegate
            {
                new GerenciadorTarefa().Remover(index);
                CarregarTarefas();
            };
            Delete.GestureRecognizers.Add(DeleteTap);

            //Imagem de Prioridade
            Image Prioridade = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("img" + tarefas.Prioridade + ".png"), WidthRequest = 30, HeightRequest = 30 };
            /*if(Device.RuntimePlatform == Device.Windows)
            {
                Prioridade.Source = ImageSource.FromFile("Caminhodapasta/" + tarefas.Prioridade + ".png");
            }*/

            View StackCentral = null;
            if(tarefas.DataFinalizacao == null)
            {
                StackCentral = new Label() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand, Text = tarefas.Nome };
            }
            else
            {
                StackCentral = new StackLayout() { VerticalOptions = LayoutOptions.Center, Spacing = 0, HorizontalOptions = LayoutOptions.FillAndExpand };
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = tarefas.Nome, TextColor = Color.Gray });

                ((StackLayout)StackCentral).Children.Add(new Label() { Text = "Finalizado em " + tarefas.DataFinalizacao.Value.ToString("dd/MM/yyyy - hh:mm") + "h", TextColor = Color.Gray, FontSize = 10 });

            }
            

            //Imagem de CheckOff
            Image Check = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("checkOff.png"), WidthRequest = 30, HeightRequest = 30 };
            /*if(Device.RuntimePlatform == Device.Windows)
            {
                Check.Source = ImageSource.FromFile("Caminhodapasta/checkOff.png");
            }*/
            if(tarefas.DataFinalizacao != null)
            {
                Check.Source = ImageSource.FromFile("checkOn.png");
            }


            TapGestureRecognizer CheckTap = new TapGestureRecognizer();
            CheckTap.Tapped += delegate
            {
                new GerenciadorTarefa().Finalizar(index, tarefas);
                CarregarTarefas();
            };
            Check.GestureRecognizers.Add(CheckTap);


            StackLayout Linha = new StackLayout() { Orientation = StackOrientation.Horizontal, Spacing = 15 };

            Linha.Children.Add(Check);
            Linha.Children.Add(StackCentral);
            Linha.Children.Add(Prioridade);
            Linha.Children.Add(Delete);

            SLTarefas.Children.Add(Linha);
        }
    }
}