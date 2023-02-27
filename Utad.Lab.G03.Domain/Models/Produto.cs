using System;
using System.Collections.Generic;
using System.Text;

namespace Utad.Lab.G03.Domain.Models
{
    public class Produto
    {
        //public int ID { get; set; }
       public string Nome { get; set; }
        public string Quantidade { get; set; }
        public string Categoria { get; set; }
        public string TipoUnidade { get; set; }
        
        

        public Produto()
        {
            //this.ID = 0;
            this.Nome = string.Empty;
            this.Quantidade = string.Empty;
            this.TipoUnidade = string.Empty;
            this.Categoria = string.Empty;
            
        }

        public Produto(int _id, string _nome, string _quantidade, string _tipo, string _categoria)
        {
            //this.ID = _id;
            this.Nome = _nome;
            this.Quantidade = _quantidade;
            this.TipoUnidade = _tipo;
            this.Categoria = _categoria;
        }

        
        
    }
}
