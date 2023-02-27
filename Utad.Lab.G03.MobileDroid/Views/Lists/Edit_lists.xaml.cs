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
    public partial class Edit_lists : ContentPage
    {
        int id_;
        string nome_;
        int chose=0;
        string newNomeLista;
        List_ProductsViewModel A = new List_ProductsViewModel();

        public Edit_lists(int _id, string _nome)
        {
            id_ = _id;
            nome_ = _nome;
            InitializeComponent();
           
        }

        private void Btn_Edit(object sender, System.EventArgs e)
        {
            chose = id_;
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListFile.xml");

            XDocument doc = XDocument.Load(_filename);
            XElement lists = doc.Root.Element("Listas"); //testing
            var listas = from lst in doc.Root.Elements("Listas").Descendants("Lista")
                         where lst.Attribute("id").Value == Convert.ToString(chose)
                         select lst;
             newNomeLista = newNameEntry.Text;
            foreach (var aux in listas)
            {
                aux.Attribute("nome").Value = newNomeLista;
            }
            doc.Save(_filename); //nome modificado para não alterar o original
            //A.ProductName = newNomeLista;
            nome_=newNomeLista;
            Navigation.PushModalAsync(new List_Product(id_, nome_));
        }

        private void Btn_Delete(object sender, System.EventArgs e)
        {
            chose = id_;
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListFile.xml");

            XDocument doc = XDocument.Load(_filename);

            var listas = from lst in doc.Root.Elements("Listas").Elements("Lista")
                         where lst.Attribute("id").Value == Convert.ToString(chose)
                         select lst;

            listas.Remove();
            
            doc.Save(_filename); //nome modificado para não alterar o original

            XElement lists = doc.Root.Element("Listas"); //testing
            Navigation.PushModalAsync(new Lists());
            
        }
        private void Btn_Back(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new List_Product(id_, nome_));
        }
    }
}