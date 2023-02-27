using System;
using System.Collections.Generic;
using System.Text;

namespace Utad.Lab.G03.Domain.Models
{
    public class Lista
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public List<Produto> ListProd;

        public Lista()
        {
            this.ID = 0;
            this.Nome = String.Empty;
            this.ListProd = new List<Produto>();
        
        }

        public Lista(int _id, string nome, List<Produto> list)
        {
            
        }

        public void RemoveProductList(Produto prod)
        {
            ListProd.Remove(prod);
        }



    }
}
