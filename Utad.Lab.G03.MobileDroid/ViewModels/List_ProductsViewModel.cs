using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Utad.Lab.G03.Domain.Models;

namespace Utad.Lab.G03.MobileDroid.ViewModels
{

    public class List_ProductsViewModel
    {
        public ObservableCollection<Produto> DBProducts { get; set; }
        //public String ProductName { get; set; }
        int chose = 0;
        public List_ProductsViewModel(int id_, string nome_)
        {
            DBProducts = new ObservableCollection<Produto> { };
           
            //ProductName= nome_;
           // DBProducts.Add(new Produto { Nome = "Pizza", Quantidade = "1", Categoria = "Mercearia", TipoUnidade = "Unity" });
            //DBProducts.Add(new Produto { Nome = "Meia de leite", Quantidade = "1", Categoria = "Bar", TipoUnidade = "Unity" });
            chose = id_;
            ReadProductsDefault();
            

        }

        public List_ProductsViewModel()
        {

        }

        private void ReadProductsDefault()
        {
            //doc.Root.Element("Listas").Add(new XElement("Lista"), new XAttribute("nome", NomeLista), new XAttribute("id", Id));
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListFile.xml");
            XDocument doc = XDocument.Load(_filename);

            var listas = from lst in doc.Root.Elements("Listas").Descendants("Lista")
                         where lst.Attribute("id").Value == Convert.ToString(chose)
                         select lst;

            foreach (var aux in listas)
            {
                //Lista nova = new Lista() { Nome = aux.Attribute("nome").Value };

                var prdts = from al in aux.Descendants("Produto") select al;
                foreach (var temp in prdts)
                {
                    Produto p = new Produto();
                    p.Nome = temp.Attribute("nome").Value;
                    p.Quantidade = temp.Attribute("quantidade").Value;
                    p.Categoria = temp.Attribute("categoria").Value;
                    p.TipoUnidade = temp.Attribute("tipoUnidade").Value;
                    DBProducts.Add(p);
                }

            }


        }
    }
}
