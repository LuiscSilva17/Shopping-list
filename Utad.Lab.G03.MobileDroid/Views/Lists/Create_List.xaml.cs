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
    public partial class Create_List : ContentPage
    {
        string NomeLista;
        new int Id;

        Lists_ViewModel A = new Lists_ViewModel();
        public Create_List()
        {
          InitializeComponent();
          //doc.Root.Element("Listas").Add(new XElement("Lista"), new XAttribute("nome", NomeLista), new XAttribute("id", Id));
        }

        private void Btn_Create(object sender, System.EventArgs e)
        {

            Id = A.DBLists.Count() + 1;
            //A.DBLists.Clear();
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListFile.xml");

            XDocument doc = XDocument.Load(_filename);
            NomeLista = NameEntry.Text;
            XElement lists = doc.Root.Element("Listas");
            XElement no = new XElement("Lista", new XAttribute("nome", NomeLista), new XAttribute("id", Id));
            lists.Add(no);
            doc.Save(_filename); //nome modificado para não alterar o original
            Navigation.PushModalAsync(new Lists());
        }
        private void Btn_Back(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Lists());
        }

    }
}