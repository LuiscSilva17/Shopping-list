using System;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Utad.Lab.G03.MobileDroid.Views;
using Xamarin.Forms;
using Utad.Lab.G03.MobileDroid.ViewModels;

namespace Utad.Lab.G03.MobileDroid.Views
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login_Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Login_Page" /> class.
        /// </summary>
        public Login_Page()
        {
            this.InitializeComponent();
 
        }

        public void Btn_Login_click(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp());
        }

        private void Btn_Login_exit(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new MainPage());
        }

        private void Btn_Forgot(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ForgotPassword());
        }

        private void Btn_Lists_open(object sender, EventArgs e)
        {
            App.Current.MainPage = new Lists();
        }
    }
}