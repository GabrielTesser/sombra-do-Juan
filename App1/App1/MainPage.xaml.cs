using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private string conteudoArrastado;
        public MainPage()
        {
            InitializeComponent();
            juan.Source = ImageSource.FromResource("App1.cavalo.juan.jpg");
        }

        private async void selecao_Drop(object sender, DropEventArgs e)
        {

            conteudoArrastado = juan.Source.ToString();

            if (e.Data != null)
            {
                await DisplayAlert("Caballo", "sim funfa", "cavalo");
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

        }

     
    } 
}
