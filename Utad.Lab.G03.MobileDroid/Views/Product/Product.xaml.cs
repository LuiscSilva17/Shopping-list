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
    public partial class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        int id_;
        string nome_;
        public Product(int _id, string _nome)
        {
            id_= _id;
            nome_= _nome;
            InitializeComponent();
            BindingContext = new ProductsViewModel();
        }

        public Product()
        {
          
        }

        private void Btn_Back(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new List_Product(id_,nome_));
        }

        private void Btn_Add(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Edit_Product(id_, nome_));

        }
        private void Btn_Create(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Create_Product(id_, nome_));
        }

        private void OnItemSelected(object sender, ItemTappedEventArgs e)
        {

            var info = e.Item as Produto;
            Navigation.PushModalAsync(new Add_ProductInfo(info.Nome, id_, nome_));

        }
    }
}