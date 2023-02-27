using Utad.Lab.G03.MobileDroid.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Utad.Lab.G03.MobileDroid.ViewModels;
using Utad.Lab.G03.Domain.Models;

namespace Utad.Lab.G03.MobileDroid.Views
{
    /// <summary>
    /// Page to display the file explorer list.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Category_List
    {
       
        public Category_List()
        {
            InitializeComponent();
            BindingContext = new CategoryList_ViewModel();

        }

        private void Btn_Back(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Settings_Page());

        }
        private void Btn_Create(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Create_Category());

        }

        private void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            
            var info = e.Item as Categoria;
            Navigation.PushModalAsync(new Edit_Category(info.Nome));

        }
    }
}