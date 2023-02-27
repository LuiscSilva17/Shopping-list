using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Utad.Lab.G03.MobileDroid.Views
{
    /// <summary>
    /// Page to sign in with user details.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignUp" /> class.
        /// </summary>
        public SignUp()
        {
            this.InitializeComponent();
        }

        private void Btn_Login_clk(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login_Page());
        }

        private void Btn_Register_clk(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Profile_Page());
        }
    }
}