using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ConsultarCepNovo.Servico.Modelo;
using ConsultarCepNovo.Servico;

namespace ConsultarCepNovo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BOTAO.Clicked += BuscarCEP;



		}
        private void BuscarCEP(object sender, EventArgs args)
        {
           
            //Todo - Validações
            string cep = CEP.Text.Trim();

            if (isValidCEP(cep))
            {
                try
                {
                    Endereco end = ViaCepServico.BuscaEnderecoViaCep(cep);

                    if(end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço: {2} de {3} {0},{1}  ", 
                                                        end.Localidade, 
                                                        end.Uf, 
                                                        end.Logradouro, 
                                                        end.Bairro);
                        CEP.Text = "";
                    }
                    else
                    {
                        DisplayAlert("ERRO", "Endereço não Encontrado para o CEP Digitado: " +cep, "Ok");
                        CEP.Text = "";
                    }
                    
                }
                catch (Exception e)
                {

                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
                
            }
            
        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;

            if(cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP Inválido! O CEP deve conter 8 caractéres.", "Ok");

                valido = false;
            }
            int NovoCEP = 0;
            if(!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("ERRO", "CEP Inválido! O CEP deve ser composto apenas por números!", "Ok");

                valido = false;
            }
            return valido;
        }
	}
}
