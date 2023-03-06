using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExaRad1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagecontacto : ContentPage
    {
        public Pagecontacto()
        {
            InitializeComponent();
        }
        private async void Btmostrar_clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Llene todos los campos");
        }

        private Task DisplayAlert(string v)
        {
            throw new NotImplementedException();
        }
    }
    }

   
