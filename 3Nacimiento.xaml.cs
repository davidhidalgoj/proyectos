using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nacimiento : ContentPage
    {
        public Nacimiento()
        {
            InitializeComponent();
            buttonCorreo.Clicked += ButtonCorreo_Clicked;
        }

        private void ButtonCorreo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Correo());
        }
    }
}