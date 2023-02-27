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
    public partial class Edit_Product : ContentPage
    {
        int id_, pid;
        string nome_, pnome_;
        string prodname, newprodname, newquant, newcat, newtype;
        public Edit_Product(string _pnome,int _id, string _nome)
        {
            id_ = _id;
            nome_ = _nome;
            pnome_ = _pnome;
           InitializeComponent();
        }

        public Edit_Product( int _id, string _nome)
        {
            id_ = _id;
            nome_ = _nome;       
            InitializeComponent();
        }
        public Edit_Product()
        {
            InitializeComponent();
        }

        private void Btn_Back(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new List_Product(id_, nome_));
        }

        private void Btn_Edit(object sender, System.EventArgs e)
        {
            prodname = pnome_;
            pid = id_;
            newprodname = newProdEntry.Text;
            newquant = newQuantEntry.Text;
            newcat = newCatEntry.Text;
            newtype = newTypeEntry.Text;


            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListFile.xml");

            XDocument doc = XDocument.Load(_filename);
            var prods1= from lst in doc.Root.Elements("Listas").Descendants("Lista")
                       where lst.Attribute("id").Value == Convert.ToString(pid)                    
                       select lst;
            foreach (var aux1 in prods1)
            {
                var prods2 = from pdt in prods1.Elements("Produtos").Elements("Produto")
                             where pdt.Attribute("nome").Value == prodname
                             select pdt;

                foreach(var aux2 in prods2)
                {
                      aux2.Attribute("nome").Value = newprodname;
                      aux2.Attribute("quantidade").Value = newquant;
                      aux2.Attribute("categoria").Value = newcat;
                      aux2.Attribute("tipoUnidade").Value = newtype;

                }
            }

            doc.Save(_filename); //nome modificado para não alterar o original

            Navigation.PushModalAsync(new List_Product(id_, nome_));
        }

        private void Btn_Delete(object sender, System.EventArgs e)
        {

        }
    }
}