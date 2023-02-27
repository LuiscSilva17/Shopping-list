using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Utad.Lab.G03.MobileDroid.Views
{
    /// <summary>
    /// Page to show the setting.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings_Page : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Settings_Page" /> class.
        /// </summary>
        public Settings_Page()
        {
            this.InitializeComponent();

        }

        public void Btn_Exit_clk(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Lists());
        }

        public void Btn_Logout_clk(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new Login_Page();
        }

        public void Btn_Edit_clk(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Edit_Profile());
        }

        private void Btn_Lists_Products(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new List_Product());

        }
        private void Btn_Lists_Category(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Category_List());

        }
    }
}