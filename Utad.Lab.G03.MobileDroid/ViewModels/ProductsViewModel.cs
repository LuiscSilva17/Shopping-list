using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Utad.Lab.G03.Domain.Models;

namespace Utad.Lab.G03.MobileDroid.ViewModels
{
    public class ProductsViewModel
    {
        public ObservableCollection<Produto> DBLProducts { get; set; }

        public ProductsViewModel()
        {
        DBLProducts = new ObservableCollection<Produto>();
        //DBLProducts.Add(new Produto { Nome="Alface", Quantidade="1", Categoria="Mercearia", TipoUnidade="KG"});
        ReadLProductsDefault();
            




        }

        public void ReadLProductsDefault()
        {
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListFile.xml");
            XDocument doc = XDocument.Load(_filename);


            var lts = from al in doc.Descendants("Produto") select al;
            foreach(var aux in lts)
            {
                Produto p = new Produto();
                p.Nome = (string)aux.Attribute("nome");
                DBLProducts.Add(p);
            }


        }


    }
}
