using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            //ImageOne.IsLoading

            Image imagem = new Image();

            imagem.Source = ImageSource.FromFile("ic_launcher.png");

            Container.Children.Add(imagem);



        }
	}
}