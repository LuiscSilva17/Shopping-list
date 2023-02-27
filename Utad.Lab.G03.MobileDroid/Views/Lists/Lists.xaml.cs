using Utad.Lab.G03.Domain.Models;
using Utad.Lab.G03.MobileDroid.DataService;
using Utad.Lab.G03.MobileDroid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Utad.Lab.G03.MobileDroid.Views
{
    /// <summary>
    /// Page to display the file explorer list.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lists : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lists" /> class.
        /// </summary>
        /// 
        int id_;
        string nome_;
        public Lists()
        {
            InitializeComponent();
            BindingContext = new Lists_ViewModel();
        }

        private void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var info = e.Item as Lista;      
            Navigation.PushModalAsync( new List_Product(info.ID, info.Nome) );
        }

        private void Btn_Setting(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Settings_Page());
        }

        private void Btn_Add(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Create_List());
        }

    }
}