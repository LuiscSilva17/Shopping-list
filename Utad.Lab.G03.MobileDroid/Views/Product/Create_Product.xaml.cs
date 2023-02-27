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
    public partial class Create_Product : ContentPage
    {
        int id_;
        string nome_;

        public Create_Product(int _id, string _nome)
        {
            id_ = _id;
            nome_ = _nome;
            InitializeComponent();
        }
        public Create_Product()
        {
            InitializeComponent();
        }

        private void Btn_Create(object sender, System.EventArgs e)
        {
           Navigation.PushModalAsync(new Product(id_, nome_));
        }
        private void Btn_Back(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Product(id_, nome_));
        }
    }
}