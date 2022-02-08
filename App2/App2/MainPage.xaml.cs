using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_Zarega_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page1());
        }

        private void btn_vhod_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Новая_папка1.проекты());
        }
    }
}
