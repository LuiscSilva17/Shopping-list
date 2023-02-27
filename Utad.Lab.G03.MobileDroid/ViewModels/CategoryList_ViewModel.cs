using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml;
using System.Threading.Tasks;
using Utad.Lab.G03.Domain.Models;
using System.Xml.Linq;
using System.IO;

namespace Utad.Lab.G03.MobileDroid.ViewModels
{
   
    public class CategoryList_ViewModel
    {
        public ObservableCollection<Categoria> DBCategoria { get; set; }



        public CategoryList_ViewModel()
        {
            DBCategoria = new ObservableCollection<Categoria>();
            DBCategoria.Add(new Categoria{ Nome = "Mercearia"});
            ReadCatsDefault();
        }

        public void ReadCatsDefault()
        {
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListFile.xml");

            XDocument doc = XDocument.Load(_filename);

            var lts = from al in doc.Descendants("Categoria") select al;
            foreach (var aux in lts)
            {
                Categoria c = new Categoria();
                c.Nome = (string)aux.Attribute("nome");        
                DBCategoria.Add(c);
            }
        }



    }
}