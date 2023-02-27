using System;
using Utad.Lab.G03.MobileDroid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Utad.Lab.G03.MobileDroid.Views
{
    /// <summary>
    /// Page to show the article profile
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Edit_Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Edit_Profile" /> class.
        /// </summary>
        public Edit_Profile()
        {
            this.InitializeComponent();
            this.BindingContext = ProfileViewModel.BindingContext;
        }


            public void Btn_Exit_clk(object sender, EventArgs e)
            {
            Navigation.PushModalAsync(new Settings_Page());
        }

        private void Btn_Change(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Change_Profrile());

        }
    }
}