using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(altura.Text) && !string.IsNullOrEmpty(peso.Text))
            {
                var al = double.Parse(altura.Text);
                var pe = double.Parse(peso.Text);

                var resultado = pe / (al * al);
                resultadoo.Text = resultado.ToString();

                string res = "";

                if (resultado < 18.5)
                {
                    res = "Tienes bajo peso";
                }
                else if (resultado >= 18.5 && resultado <= 24.99)
                {
                    res = "Tu peso es normal";
                }
                else if (resultado >= 25 && resultado <= 29.99)
                {
                    res = "Tienes sobrepeso";
                }
                else
                {
                    res = "Tienes obesidad";
                }

                DisplayAlert("Resultado", res, "Ok");
            }
            else
            {
                DisplayAlert("Datos erroneos", "Lena todos los datos", "Ok");
            }
        }
    }
}
