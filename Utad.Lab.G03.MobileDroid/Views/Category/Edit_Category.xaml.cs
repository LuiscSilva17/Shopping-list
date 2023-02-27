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
    public partial class Edit_Category : ContentPage
    {
        string nome_;
        string catname, newcatname;
        public Edit_Category(string _nome)
        {
           nome_ = _nome;
           InitializeComponent();
        }
        public Edit_Category()
        {
            InitializeComponent();
        }

        private void Btn_Change(object sender, System.EventArgs e)
        {
            catname= nome_;
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListFile.xml");

            XDocument doc = XDocument.Load(_filename);
            var cats = from lst in doc.Root.Elements("Categorias").Descendants("Categoria")
                       where lst.Attribute("nome").Value == catname
                       select lst;
            newcatname = newCatEntry.Text;
            foreach (var aux in cats)
            {
                aux.Attribute("nome").Value = newcatname;
            }
            doc.Save(_filename); //nome modificado para não alterar o original
            Navigation.PushModalAsync(new Category_List());
        }

        private void Btn_Delete(object sender, System.EventArgs e)
        {
            catname = nome_;
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListFile.xml");

            XDocument doc = XDocument.Load(_filename);

            var cats = from lst in doc.Root.Elements("Categorias").Elements("Categoria")
                         where lst.Attribute("nome").Value == catname
                         select lst;
            cats.Remove();

            doc.Save(_filename); //nome modificado para não alterar o original
            Navigation.PushModalAsync(new Category_List());
        }

        private void Btn_Back_clk(object sender, System.EventArgs e)
        {

            Navigation.PushModalAsync(new Category_List());

        }

        
       
    }
}