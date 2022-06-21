using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btninformacion_clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text) && !string.IsNullOrEmpty(txtapellido.Text) && !string.IsNullOrEmpty(txtedad.Text) && !string.IsNullOrEmpty(txtcorreo.Text))
            {
                var Usuario = new Models.Usuario();
                Usuario.nombre = txtnombre.Text;
                Usuario.apellido = txtapellido.Text;
                Usuario.edad = txtedad.Text;
                Usuario.correo = txtcorreo.Text;
                SecondPage page = new SecondPage();
                page.BindingContext = Usuario;
                await Navigation.PushAsync(page);
            }
            else
            {
                DisplayAlert("Aviso", "Necesita llenar los campos.", "Ok");
            }
        }
    }
}
