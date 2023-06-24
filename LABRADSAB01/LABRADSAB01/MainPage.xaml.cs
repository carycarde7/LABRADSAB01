using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LABRADSAB01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnproceso_Clicked(object sender, EventArgs e)
        {

            /*
            var resultado = Convert.ToDouble(numero1.Text) + Convert.ToDouble(numero2.Text);

            //await DisplayAlert("Aviso", "El resultado es" + resultado.ToString(), "ok");

            if (resultado > 0)
            {
                Views.PageResultado page = new Views.PageResultado(Convert.ToString(resultado));
                await Navigation.PushAsync(page);
            }
            else
                await DisplayAlert("Aviso", "no coloco datos", "ok");
            */

            var Personas = new Models.Personas
            {
                Id = 1,
                Nombres = "Carol",
                Apellidos = "Carde",
                FechaNac = DateTime.Now,
                Telefono = "98888888"

            };
            Views.PageResultado page = new Views.PageResultado();
            page.BindingContext= Personas;
            await Navigation.PushAsync(page);

        }

    }
}
