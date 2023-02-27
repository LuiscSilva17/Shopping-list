using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utad.Lab.G03.MobileDroid.Views;
using Xamarin.Forms;

namespace Utad.Lab.G03.MobileDroid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Btn_MainPage_clk(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login_Page());
        }


    }
}
