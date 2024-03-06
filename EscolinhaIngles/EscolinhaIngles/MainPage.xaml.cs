using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EscolinhaIngles
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCores());
        }

        private void btnNumeros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageNumeros());
        }

        private void btnFamilia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageFamilia());
        }

        private void btnNumeros_Clicked_1(object sender, EventArgs e)
        {

        }

        private void btnSair_Clicked(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch 
            {

            }
        }
    }
}
