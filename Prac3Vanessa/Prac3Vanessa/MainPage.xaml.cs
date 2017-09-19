using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prac3Vanessa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("DATOS INGRESADOS", Nombre.Text + " " + Apellidos.Text + "\n " + Direccion.Text + " \n " + Telefono.Text + " \n" + Carrera.Text + " \n" + Semestre.Text + "\n " + Matricula.Text + "\n " + Correo.Text + "\n " + Github.Text, "OK");
        }

    }
}
