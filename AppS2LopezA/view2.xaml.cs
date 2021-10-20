using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS2LopezA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class view2 : ContentPage
    {
        public view2()
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //convertir el valor txt a dobule.
                double valor1 = Convert.ToDouble(txtValorUno.Text);
                double valor2 = Convert.ToDouble(txtValorDos.Text);

                //operaciones.
                double suma = valor1 + valor2;

                //visualizar resultado en pantalla.
                txtResultado.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "OK");
            }

        }
    }
}