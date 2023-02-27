using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Utad.Lab.G03.Domain.Models
{
    public class Model
    {
        public List<Categoria> Categorias { get; set; }
        public List<Lista> Listas { get;  set; }
        public List<Produto> Produtos { get; set; }

        public Model()
        {
            Listas = new List<Lista>();
            Categorias = new List<Categoria>();
            Produtos = new List<Produto>();

        }

        //Lê listas
        public void CarregaListas(string file)
        {
            //Limpa estrutura de dados
            Listas.Clear();

            XDocument doc = XDocument.Load(file);

            var listas = from lst in doc.Root.Elements("Listas").Descendants("Lista") select lst;

            foreach (var aux in listas)
            {

                Lista novaLista = new Lista() { ID = Convert.ToInt32(aux.Attribute("id").Value), Nome = aux.Attribute("nome").Value };

                var produtos = from al in aux.Descendants("Produto") select al;

                foreach (var tmp in produtos)
                {
                    Produto p = new Produto();
                    //p.ID = tmp.Attribute("id").Value;
                    p.Nome = tmp.Attribute("nome").Value;
                    p.Quantidade = tmp.Attribute("quantidade").Value;
                    p.Categoria = tmp.Attribute("categoria").Value;
                    p.TipoUnidade = tmp.Attribute("tipoUnidade").Value;

                    novaLista.ListProd.Add(p);
                }

                Listas.Add(novaLista);

            }

        }

        //Lê categorias do xml para apresentar na pagina das categorias
        public void CarregaCategorias(string file)
        {
            //Limpa estrutura de dados
            Categorias.Clear();

            XDocument doc = XDocument.Load(file);

            var listas = from lst in doc.Elements("ListasCompras").Elements("Categorias") select lst;

            foreach (var aux in listas)
            {
                var categorias = from al in aux.Descendants("Categoria") select al;

                foreach (var tmp in categorias)
                {
                    Categoria c = new Categoria();
                    //p.ID = tmp.Attribute("id").Value;
                    c.Nome = tmp.Attribute("nome").Value;

                    Categorias.Add(c);
                }
            }

        }

        //Lê produtos para carregar para a listview dos produtos
        public void CarregaProdutos(string file)
        {
            //Limpa estrutura de dados
            Produtos.Clear();

            XDocument doc = XDocument.Load(file);

            var listas = from lst in doc.Root.Elements("Listas").Descendants("Lista") select lst;

            foreach (var aux in listas)
            {
                var produtos = from al in aux.Descendants("Produto") select al;

                foreach (var tmp in produtos)
                {
                    Produto p = new Produto();
                    //p.ID = tmp.Attribute("id").Value;
                    p.Nome = tmp.Attribute("nome").Value;
                    p.Quantidade = tmp.Attribute("quantidade").Value;
                    p.Categoria = tmp.Attribute("categoria").Value;
                    p.TipoUnidade = tmp.Attribute("tipoUnidade").Value;

                    Produtos.Add(p);
                }
            }

        }
        //Método para adicionar categorias
        public void AdicionarCategoria(string file)
        {
            
                Categoria c = new Categoria();
                c.Nome = file;
                Categorias.Add(c);
        }


        //Método para guardar categorias no XML
        public XElement SaveCategoria(XDocument doc)
        {
            XElement x = new XElement("Categorias");
            foreach (Categoria cat in Categorias)
            {

                XElement categoria = new XElement("Categoria", new XAttribute("nome", cat.Nome));
                x.Add(categoria);
            }
            return x;
        }


        public Lista AddList()
        {
            Lista novalista = new Lista();
            return novalista;
        }

        public Lista CopyList(Lista novalista)
        {

            foreach (Lista lst in Listas)
            {
                if (lst.Nome == novalista.Nome)
                {
                    novalista = lst;
                }
            }
            return novalista;
        }

        public void NewList(string name)
        {
            Lista novalista = new Lista();
            novalista.Nome = name;
            Listas.Add(novalista);
        }

        //public void SaveList(string file)
        //{
        //    XDocument doc = new XDocument(new XDeclaration("1.0", Encoding.UTF8.ToString(), "yes"),
        //                                                  new XElement("ListasCompras",
        //                                                        new XElement("Listas")));


        //    foreach(Lista lst in Listas)
        //    {
        //        XElement lista = new XElement("Lista",
        //                                            new XAttribute("nome", lst.Nome),
        //                                            new XAttribute("id", lst.ID),
        //                                            new XElement("Produtos"));

        //        foreach (Produto prod in lst.ListProd)
        //        {
        //            XElement produto = new XElement("Produto",
        //                                    new XAttribute("nome", prod.Nome),
        //                                    new XAttribute("quantidade", prod.Quantidade),
        //                                    new XAttribute("categoria", prod.Categoria),
        //                                    new XAttribute("tipoUnidade", prod.TipoUnidade));

        //            lista.Element("Produtos").Add(produto);
        //        }
        //        doc.Element("ListasCompras").Element("Listas").Add(lista);
        //    }
        //    XElement x = new XElement("Categorias");
        //    foreach(Categoria cat in Categorias)
        //    {

        //        XElement categoria = new XElement("Categoria", new XAttribute ("nome",cat.Nome));
        //        x.Add(categoria);
        //    }
        //    if(file != null)
        //    {
        //        doc.Save(file);
        //    }
        //    else
        //    {
        //        doc.Save("NovoFicheiro");
        //    }

        //}

        //Método para juntar as categorias ao resto dos dados no XML
        public void SaveList(string file)
        {
            XDocument doc = new XDocument(new XDeclaration("1.0", Encoding.UTF8.ToString(), "yes"),
                                                          new XElement("ListasCompras",
                                                                new XElement("Listas")));

            doc.Element("ListasCompras").Add(SaveCategoria(doc));
            foreach (Lista lst in Listas)
            {
                XElement lista = new XElement("Lista",
                                                    new XAttribute("nome", lst.Nome),
                                                    new XAttribute("id", lst.ID),
                                                    new XElement("Produtos"));

                foreach (Produto prod in lst.ListProd)
                {
                    XElement produto = new XElement("Produto",
                                            new XAttribute("nome", prod.Nome),
                                            new XAttribute("quantidade", prod.Quantidade),
                                            new XAttribute("categoria", prod.Categoria),
                                            new XAttribute("tipoUnidade", prod.TipoUnidade));

                    lista.Element("Produtos").Add(produto);
                }
                doc.Element("ListasCompras").Element("Listas").Add(lista);
            }
            if (file == null)
            {
                file = "NewXMLFile.xml";
                doc.Save(file);
            }
            else
            {
                doc.Save(file);
            }

        }


        public void AddProducttoProducts(Produto novoproduto)
        {
            //Adiciono novo produto á lista de produtos
            foreach (Produto p in Produtos)
            {
                if (novoproduto.Nome == p.Nome && novoproduto.Categoria == p.Categoria && novoproduto.TipoUnidade == p.TipoUnidade)
                {
                    int quantidade;
                    quantidade = Convert.ToInt32(p.Quantidade) + Convert.ToInt32(novoproduto.Quantidade);
                    novoproduto.Quantidade = Convert.ToString(quantidade);
                    Produtos.Remove(p);
                    Produtos.Add(novoproduto);
                    return;
                }
            }

            Produtos.Add(novoproduto);
        }

        public void AddProduct(Produto prod, string nomeLista)
        {
            if (prod != null)
            {
                //Crio novo produto
                Produto novoproduto = new Produto();
                novoproduto.Nome = prod.Nome;
                novoproduto.Quantidade = prod.Quantidade;
                novoproduto.Categoria = prod.Categoria;
                novoproduto.TipoUnidade = prod.TipoUnidade;


                //Adiciono novo produto à lista especifica 
                foreach (Lista lst in Listas)
                {
                    if (lst.Nome == nomeLista)
                    {
                        foreach(Produto p in lst.ListProd)
                        {
                            if(novoproduto.Nome == p.Nome && novoproduto.Categoria == p.Categoria && novoproduto.TipoUnidade == p.TipoUnidade)
                            {
                                int quantidade;
                                quantidade = Convert.ToInt32(p.Quantidade) + Convert.ToInt32(novoproduto.Quantidade);
                                p.Quantidade = Convert.ToString(quantidade);
                                return;
                            }   
                        }    
                             lst.ListProd.Add(novoproduto);
                          
                    }
                }

            }
        }

        public void RemoveList(string nome)
        {
            Lista l = Listas.Find(l => l.Nome.Equals(nome));
            Listas.Remove(l);
        }










    }
}
