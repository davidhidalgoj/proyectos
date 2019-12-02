using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFinal
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Inicio();
            buttonApellidos.Clicked += ButtonApellidos_Clicked;
        }

        private void ButtonApellidos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Apellidos());
        }

        private void Inicio()
        {
            buttonNombre.Clicked += ButtonTexto_Clicked;
        }

        private void ButtonTexto_Clicked(object sender, EventArgs e)
        {
            labelInicio.Text += "hola" + entryTexto.Text;
        }
    }
}