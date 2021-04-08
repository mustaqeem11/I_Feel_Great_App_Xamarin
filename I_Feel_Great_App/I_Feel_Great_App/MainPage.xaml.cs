using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace I_Feel_Great_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Yes_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("System", "It is highly likely this is a female", "Ok");
        }
        async void No_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("System", "It is likely this is male", "Ok");
        }
    }
}
