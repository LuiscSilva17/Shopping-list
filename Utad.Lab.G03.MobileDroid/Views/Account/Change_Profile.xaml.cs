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
    public partial class Change_Profrile : ContentPage
    {
        public Change_Profrile()
        {
            InitializeComponent();
        }

        private void Btn_Change_exit(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Edit_Profile());

        }
        private void Btn_Back(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Edit_Profile());

        }
    }
}