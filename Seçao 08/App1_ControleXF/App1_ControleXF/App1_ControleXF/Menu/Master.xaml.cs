using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_ControleXF.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoActivityIndicatorPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage( new Controles.ActivityIndicatorPage());
            IsPresented = false;
        }

        private void GoProgressBarPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.ProgressBarPage());
            IsPresented = false;
        }

        private void GoBoxViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.BoxViewPage());
            IsPresented = false;
        }

        private void GoLabelPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.LabelPage());
            IsPresented = false;
        }

        private void GoButtonPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.ButtonPage());
            IsPresented = false;
        }

        private void GoEntryEditorPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.EntryEditorPage());
            IsPresented = false;
        }

        private void GoDatePickerPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.DatePickerPage());
            IsPresented = false;
        }

        private void GoTimerPickerPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.TimerPickerPage());
            IsPresented = false;
        }

        private void GoPickerPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.PickerPage());
            IsPresented = false;
        }

        private void GoSearchBarPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.SearchBarPage());
            IsPresented = false;
        }

        private void GoSliderStepperPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.SliderStepperPage());
            IsPresented = false;
        }

        private void GoSwitchPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.SwitchPage());
            IsPresented = false;
        }

        private void GoImagePage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.ImagePage());
            IsPresented = false;
        }

        private void GoListViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.ListViewPage());
            IsPresented = false;
        }

        private void GoTableViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.TableViewPage());
            IsPresented = false;
        }

        private void GoWebViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.WebViewPage());
            IsPresented = false;
        }
    }
}