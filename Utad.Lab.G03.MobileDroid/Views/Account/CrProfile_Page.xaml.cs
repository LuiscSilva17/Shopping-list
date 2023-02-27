using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Utad.Lab.G03.MobileDroid.Views
{
    /// <summary>
    /// This page used for adding Profile image with Name and phone number.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile_Page : ContentPage
    {
        public Profile_Page()
        {
            this.InitializeComponent();
        }

        private void Btn_Return_clk(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp());
        }

        private void Btn_Create_clk(object sender, EventArgs e)
        {
            App.Current.MainPage = new Lists();
        }
    }
}