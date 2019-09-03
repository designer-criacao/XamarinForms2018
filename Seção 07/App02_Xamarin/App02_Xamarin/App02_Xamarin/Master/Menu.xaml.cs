using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_Xamarin.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GoPaginaPerfil1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Perfil01());
            IsPresented = false;
            //Navigation.PushAsync(new Pages.Perfil01());
        }

        private void GoPaginaXamarin(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Xamarin());
            IsPresented = false;
            //Navigation.PushAsync(new Pages.Xamarin());
        }

        private void GoPaginaPerfil02(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Perfil02());
            IsPresented = false;
        }

        private void GoPaginaPerfil03(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Perfil03());
            IsPresented = false;
        }
    }
}