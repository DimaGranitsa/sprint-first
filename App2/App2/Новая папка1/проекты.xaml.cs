using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Новая_папка1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class проекты : ContentPage
    {
        public проекты()
        {
            InitializeComponent();
        }

        private void Grid_LayoutChanged(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new проект1_1());
        }
    }
}