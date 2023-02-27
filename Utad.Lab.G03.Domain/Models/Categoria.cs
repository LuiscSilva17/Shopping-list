using System;
using System.Collections.Generic;
using System.Text;

namespace Utad.Lab.G03.Domain.Models
{
    public class Categoria
    {
        //public int ID { get; set; }
        public string Nome { get; set; }

        public Categoria()
        {
            this.Nome = string.Empty;
        }
        public Categoria(int _id, string _nome)
        {
            //ID = _id;
            Nome = _nome;  

        }
    }
}
