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
  
    public class Lists_ViewModel 
    {
        public ObservableCollection<Lista> DBLists { get; set; }
        

        public Lists_ViewModel()
        {   
            
            DBLists = new ObservableCollection<Lista>();
            //DBLists.Clear();
            //DBLists.Add(new Lista { ID = 0, Nome = "Antonio" });
            //DBLists.Add(new Lista { ID = 1, Nome = "Manuel" });
            ReadListsDefault();


        }

        private void ReadListsDefault()
        {

            var currentDiretory = Directory.GetCurrentDirectory();
            var c2 = System.Reflection.Assembly.GetExecutingAssembly().Location;

            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListFile.xml");

            XDocument doc = XDocument.Load(_filename);    

            var lts = from al in doc.Descendants("Lista") select al;
            foreach (var aux in lts)
            {
                Lista l = new Lista();  
                l.Nome = (string)aux.Attribute("nome");
                l.ID = Convert.ToInt16(aux.Attribute("id").Value);
                DBLists.Add(l);
            }
        }
    } 
}