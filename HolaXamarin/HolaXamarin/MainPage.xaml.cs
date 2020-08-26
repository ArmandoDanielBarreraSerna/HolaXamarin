using System;
using Xamarin.Forms;

namespace HolaXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var nombre = "Nombre: "+Nombre.Text + " " + "Apellido: " + Apellido.Text;
            var direccion = "Edad: " + double.Parse(Edad.Text) + " " + "Dirección: " + Dirección.Text;

            if (!string.IsNullOrEmpty(Nombre.Text) &&
                !string.IsNullOrEmpty(Apellido.Text) &&
                !string.IsNullOrEmpty(Dirección.Text))
            {

                DisplayAlert(nombre, direccion, "Ok");
            }
            else
            {
                DisplayAlert("Datos incompletos",
                    "Por favor, llena toda la información",
                    "Ok");
            }

        }
    }
}
