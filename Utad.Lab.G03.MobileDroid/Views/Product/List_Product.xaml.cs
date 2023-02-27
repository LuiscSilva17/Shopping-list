using Utad.Lab.G03.Domain.Models;
using Utad.Lab.G03.MobileDroid.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Utad.Lab.G03.MobileDroid.ViewModels;

namespace Utad.Lab.G03.MobileDroid.Views
{
    /// <summary>
    /// Page to display the file explorer list.
    /// </summary>

    public partial class List_Product : ContentPage
    {
        int id_;
        string nome_;
        public List_Product(int _id, string _nome)
        {
            id_ = _id;
            nome_ = _nome;                
            InitializeComponent();
            ListName.Text = nome_;
            BindingContext = new List_ProductsViewModel(_id, _nome);
        }

        public List_Product()
        {
            InitializeComponent();
            BindingContext = new List_ProductsViewModel();
        }

        private void Btn_Back(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Lists());
            
        }

        private void Btn_Add_Product(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Product(id_, nome_));
        }

        private void OnItemSelected(object sender, ItemTappedEventArgs e)
        {

            var info = e.Item as Produto;
            Navigation.PushModalAsync(new Edit_Product(info.Nome,id_,nome_));

        }

        private void Btn_Edit(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Edit_Product());

        }

        private void Btn_EditList(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Edit_lists(id_, nome_));

        }
    }
}