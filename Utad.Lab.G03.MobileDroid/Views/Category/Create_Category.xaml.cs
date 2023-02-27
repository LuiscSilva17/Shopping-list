using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Utad.Lab.G03.MobileDroid.ViewModels;
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
    public partial class Create_Category : ContentPage
    {
        string NomeCat;
        public Create_Category()
        {
            InitializeComponent();
        }


        private void Btn_Create(object sender, System.EventArgs e)
        {
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListFile.xml");
            XDocument doc = XDocument.Load(_filename);
            NomeCat = CatEntry.Text;
            XElement cats = doc.Root.Element("Categorias");
            XElement no = new XElement("Categoria", new XAttribute("nome", NomeCat));
            cats.Add(no);
            doc.Save(_filename); //nome modificado para não alterar o original
            Navigation.PushModalAsync(new Category_List());
        }

        private void Btn_Back(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new Category_List());
        }
    }
}