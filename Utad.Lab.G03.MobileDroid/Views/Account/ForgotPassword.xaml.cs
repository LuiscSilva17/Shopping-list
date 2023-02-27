using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Utad.Lab.G03.MobileDroid.Views
{
    /// <summary>
    /// Page to retrieve the password forgotten.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPassword
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPassword" /> class.
        /// </summary>
        public ForgotPassword()
        {
            this.InitializeComponent();
        }

        private void Btn_SignUp(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp());

        }

        private void Btn_Forgot_close (object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Login_Page()); ;
        }
    }
}