using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Windows.Shared;
using Utad.Lab.G03.Domain.Models;
using System.Xml.Linq;
using Microsoft.Win32;

namespace Utad.Lab.G03.DesktopWpf
{
    /// <summary>
    /// Interaction logic for MyList.xaml
    /// </summary>
    public partial class MyList : ChromelessWindow
    {
        private App app;

        public Lista novalista;

        public string stream;

        private bool buttonwasclicked = false;
        public MyList()
        {
            InitializeComponent();
            ////Obtencao do apontador para class app (Camada de Interligacao)
            app = App.Current as App;
            novalista = app.M_Listas.AddList();
        }

        private void CarregaListasCB()
        {
            CBLists.Items.Clear();
            foreach (Lista lst in app.M_Listas.Listas)
            {
                CBLists.Items.Add(lst.Nome);
            }
        }

        private void CarregaProdutosLV()
        {
            LVProducts.ItemsSource = app.M_Listas.Produtos;
        }

        private void CarregaCategoriasLB()
        {
            LBCategories.Items.Clear();
            foreach (Categoria cat in app.M_Listas.Categorias)
            {

                    LBCategories.Items.Add(cat.Nome);
            }

        }


        private void CarregaCategoriasCB()
        {
            CBProductCategory.Items.Clear();
            foreach (Categoria cat in app.M_Listas.Categorias)
            {
                CBProductCategory.Items.Add(cat.Nome);
            }

        }





        public void RefreshList()
        {
            LVLists.SelectedItem = null;
            LVLists.ItemsSource = null;
            LVLists.Items.Clear();
            if (novalista != null)
            {
                foreach (Produto p in novalista.ListProd)
                {
                    LVLists.Items.Add(p);
                }
            }
        }

        //Navegação no Menu

        private void NavigationProducts_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            //ListsItens
            LabelLists.Visibility = Visibility.Hidden;
            BTAddList.Visibility = Visibility.Hidden;
            LVLists.Visibility = Visibility.Hidden;
            CBLists.Visibility = Visibility.Hidden;
            BTRemoveProduct.Visibility = Visibility.Hidden;
            LabelNomeLista.Visibility = Visibility.Hidden;
            TBAddList.Visibility = Visibility.Hidden;
            BTReadFile.Visibility = Visibility.Hidden;
            BTCreateProduct.Visibility = Visibility.Hidden;
            BTSave.Visibility = Visibility.Hidden;
            BTBackToLogin.Visibility = Visibility.Hidden;
            BTDeleteList.Visibility = Visibility.Hidden;

            //ProducstItens
            LabelProducts.Visibility = Visibility.Visible;
            LVProducts.Visibility = Visibility.Visible;
            LabelNewProduct.Visibility = Visibility.Hidden;
            TBProductName.Visibility = Visibility.Hidden;
            CBProductUnity.Visibility = Visibility.Hidden;
            CBProductCategory.Visibility = Visibility.Hidden;
            BTCreateProduct2.Visibility = Visibility.Hidden;
            TBProductQuantity.Visibility = Visibility.Hidden;

            //CategoriesItens
            LabelCategories.Visibility = Visibility.Hidden;
            BTAddCategorie.Visibility = Visibility.Hidden;
            LBCategories.Visibility = Visibility.Hidden;
            BTRemoveCategory.Visibility = Visibility.Hidden;
            BTEditCategory.Visibility = Visibility.Hidden;
            BTSaveCategory.Visibility = Visibility.Hidden;
            BTAddCategory_2.Visibility = Visibility.Hidden;
            //---------------------------------------- Adicionar o que falta
            LabelNomeCategoria.Visibility = Visibility.Hidden;
            TBAddCategorie.Visibility = Visibility.Hidden;
            LabelEdiitarCategoria.Visibility = Visibility.Hidden;
            TBEditCategorie.Visibility = Visibility.Hidden;
            BTEditCategory_2.Visibility = Visibility.Hidden;

            //SettingsItens
            LabelEditProfile.Visibility = Visibility.Hidden;
            TBNewUsername.Visibility = Visibility.Hidden;
            TBNewName.Visibility = Visibility.Hidden;
            TBNewPassword.Visibility = Visibility.Hidden;
            TBNewCountry.Visibility = Visibility.Hidden;
            BTChangeEdits.Visibility = Visibility.Hidden;




            //Carrega List View dos Products
            CarregaProdutosLV();

        }

        private void NavigationLists_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            
            //ListsItens
            LabelLists.Visibility = Visibility.Visible;
            BTAddList.Visibility = Visibility.Visible;
            LVLists.Visibility = Visibility.Visible;
            CBLists.Visibility = Visibility.Visible;
            BTRemoveProduct.Visibility = Visibility.Visible;
            LabelNomeLista.Visibility = Visibility.Hidden;
            TBAddList.Visibility = Visibility.Hidden;
            BTReadFile.Visibility = Visibility.Visible;
            BTCreateProduct.Visibility = Visibility.Visible;
            BTSave.Visibility = Visibility.Visible;
            BTDeleteList.Visibility = Visibility.Visible;
            BTBackToLogin.Visibility = Visibility.Visible;

            //ProducstItens
            LabelProducts.Visibility = Visibility.Hidden;
            LVProducts.Visibility = Visibility.Hidden;
            LabelNewProduct.Visibility = Visibility.Hidden;
            TBProductName.Visibility = Visibility.Hidden;
            CBProductUnity.Visibility = Visibility.Hidden;
            CBProductCategory.Visibility = Visibility.Hidden;
            BTCreateProduct2.Visibility = Visibility.Hidden;
            TBProductQuantity.Visibility = Visibility.Hidden;

            //CategoriesItens
            LabelCategories.Visibility = Visibility.Hidden;
            BTAddCategorie.Visibility = Visibility.Hidden;
            LBCategories.Visibility = Visibility.Hidden;
            BTRemoveCategory.Visibility = Visibility.Hidden;
            BTEditCategory.Visibility = Visibility.Hidden;
            BTSaveCategory.Visibility = Visibility.Hidden;
            BTAddCategory_2.Visibility = Visibility.Hidden;
            //---------------------------------------- Adicionar o que falta
            LabelNomeCategoria.Visibility = Visibility.Hidden;
            TBAddCategorie.Visibility = Visibility.Hidden;
            LabelEdiitarCategoria.Visibility = Visibility.Hidden;
            TBEditCategorie.Visibility = Visibility.Hidden;
            BTEditCategory_2.Visibility = Visibility.Hidden;

            //SettingsItens
            LabelEditProfile.Visibility = Visibility.Hidden;
            TBNewUsername.Visibility = Visibility.Hidden;
            TBNewName.Visibility = Visibility.Hidden;
            TBNewPassword.Visibility = Visibility.Hidden;
            TBNewCountry.Visibility = Visibility.Hidden;
            BTChangeEdits.Visibility = Visibility.Hidden;

            CarregaListasCB();
        }

        private void NavigationCategories_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
            //ListsItens
            LabelLists.Visibility = Visibility.Hidden;
            BTAddList.Visibility = Visibility.Hidden;
            LVLists.Visibility = Visibility.Hidden;
            CBLists.Visibility = Visibility.Hidden;
            BTRemoveProduct.Visibility = Visibility.Hidden;
            LabelNomeLista.Visibility = Visibility.Hidden;
            TBAddList.Visibility = Visibility.Hidden;
            BTReadFile.Visibility = Visibility.Hidden;
            BTCreateProduct.Visibility = Visibility.Hidden;
            BTSave.Visibility = Visibility.Hidden;
            BTBackToLogin.Visibility = Visibility.Hidden;
            BTDeleteList.Visibility = Visibility.Hidden;

            //ProducstItens
            LabelProducts.Visibility = Visibility.Hidden;
            BTCreateProduct.Visibility = Visibility.Hidden;
            LVProducts.Visibility = Visibility.Hidden;
            LabelNewProduct.Visibility = Visibility.Hidden;
            TBProductName.Visibility = Visibility.Hidden;
            CBProductUnity.Visibility = Visibility.Hidden;
            CBProductCategory.Visibility = Visibility.Hidden;
            BTCreateProduct2.Visibility = Visibility.Hidden;
            TBProductQuantity.Visibility = Visibility.Hidden;


            //CategoriesItens
            LabelCategories.Visibility = Visibility.Visible;
            BTAddCategorie.Visibility = Visibility.Visible;
            LBCategories.Visibility = Visibility.Visible;
            BTRemoveCategory.Visibility = Visibility.Visible;
            BTEditCategory.Visibility = Visibility.Visible;
            BTSaveCategory.Visibility = Visibility.Visible;
            BTAddCategory_2.Visibility= Visibility.Hidden;
 //---------------------------------------- Adicionar o que falta
            LabelNomeCategoria.Visibility = Visibility.Hidden;
            TBAddCategorie.Visibility = Visibility.Hidden;
            LabelEdiitarCategoria.Visibility = Visibility.Hidden;
            TBEditCategorie.Visibility = Visibility.Hidden;
            BTEditCategory_2.Visibility = Visibility.Hidden;

            //SettingsItens
            LabelEditProfile.Visibility = Visibility.Hidden;
            TBNewUsername.Visibility = Visibility.Hidden;
            TBNewName.Visibility = Visibility.Hidden;
            TBNewPassword.Visibility = Visibility.Hidden;
            TBNewCountry.Visibility = Visibility.Hidden;
            BTChangeEdits.Visibility = Visibility.Hidden;

            if (buttonwasclicked)
            {
                CarregaCategoriasLB();

            }
            else
            {
                LBCategories.Items.Clear();
                LBCategories.Items.Add("Padaria");
                LBCategories.Items.Add("Bazar");
                LBCategories.Items.Add("Mercearia");
                LBCategories.Items.Add("Frios e Laticínios");
                LBCategories.Items.Add("Limpeza");
                LBCategories.Items.Add("Ferragens");
                LBCategories.Items.Add("Bricolage");
                LBCategories.Items.Add("Automóveis");
            }
                
        }

        private void NavigationSettings_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
 
            //ListsItens
            LabelLists.Visibility = Visibility.Hidden;
            BTAddList.Visibility = Visibility.Hidden;
            LVLists.Visibility = Visibility.Hidden;
            CBLists.Visibility = Visibility.Hidden;
            BTRemoveProduct.Visibility = Visibility.Hidden;
            LabelNomeLista.Visibility = Visibility.Hidden;
            TBAddList.Visibility = Visibility.Hidden;
            BTReadFile.Visibility = Visibility.Hidden;
            BTCreateProduct.Visibility = Visibility.Hidden;
            BTSave.Visibility = Visibility.Hidden;
            BTBackToLogin.Visibility = Visibility.Hidden;
            BTDeleteList.Visibility = Visibility.Hidden;

            //ProducstItens
            LabelProducts.Visibility = Visibility.Hidden;
            BTCreateProduct.Visibility = Visibility.Hidden;
            LVProducts.Visibility = Visibility.Hidden;
            LabelNewProduct.Visibility = Visibility.Hidden;
            TBProductName.Visibility = Visibility.Hidden;
            CBProductUnity.Visibility = Visibility.Hidden;
            CBProductCategory.Visibility = Visibility.Hidden;
            BTCreateProduct2.Visibility = Visibility.Hidden;
            TBProductQuantity.Visibility = Visibility.Hidden;


            //CategoriesItens
            LabelCategories.Visibility = Visibility.Hidden;
            BTAddCategorie.Visibility = Visibility.Hidden;
            LabelCategories.Visibility = Visibility.Hidden;
            BTAddCategorie.Visibility = Visibility.Hidden;
            LBCategories.Visibility = Visibility.Hidden;
            BTRemoveCategory.Visibility = Visibility.Hidden;
            BTEditCategory.Visibility = Visibility.Hidden;
            BTSaveCategory.Visibility = Visibility.Hidden;
            //---------------------------------------- Adicionar o que falta
            LabelNomeCategoria.Visibility = Visibility.Hidden;
            TBAddCategorie.Visibility = Visibility.Hidden;
            LabelEdiitarCategoria.Visibility = Visibility.Hidden;
            TBEditCategorie.Visibility = Visibility.Hidden;
            BTEditCategory_2.Visibility = Visibility.Hidden;

            //SettingsItens
            LabelEditProfile.Visibility = Visibility.Visible;
            TBNewUsername.Visibility = Visibility.Visible;
            TBNewName.Visibility = Visibility.Visible;
            TBNewPassword.Visibility = Visibility.Visible;
            TBNewCountry.Visibility = Visibility.Visible;
            BTChangeEdits.Visibility = Visibility.Visible;
        }


        //Buttons

        //Adicionar Produto
        private void BTCreateProduct_Click(object sender, RoutedEventArgs e)
        {
            //ListsItens
            LabelLists.Visibility = Visibility.Hidden;
            BTAddList.Visibility = Visibility.Hidden;
            LVLists.Visibility = Visibility.Hidden;
            CBLists.Visibility = Visibility.Hidden;
            BTRemoveProduct.Visibility = Visibility.Hidden;
            LabelNomeLista.Visibility = Visibility.Hidden;
            TBAddList.Visibility = Visibility.Hidden;
            BTReadFile.Visibility = Visibility.Hidden;
            BTCreateProduct.Visibility = Visibility.Hidden;
            BTSave.Visibility = Visibility.Hidden;
            BTBackToLogin.Visibility = Visibility.Hidden;
            BTDeleteList.Visibility = Visibility.Hidden;

            //NewProductItens
            LabelNewProduct.Visibility = Visibility.Visible;
            TBProductName.Visibility = Visibility.Visible;
            CBProductUnity.Visibility = Visibility.Visible;
            CBProductCategory.Visibility = Visibility.Visible;
            BTCreateProduct2.Visibility = Visibility.Visible;
            TBProductQuantity.Visibility = Visibility.Visible;
            if (buttonwasclicked)
            {
                CarregaCategoriasCB();
            }
            else
            {
                CBProductCategory.Items.Clear();
                CBProductCategory.Items.Add("Padaria");
                CBProductCategory.Items.Add("Bazar");
                CBProductCategory.Items.Add("Mercearia");
                CBProductCategory.Items.Add("Frios e Laticínios");
                CBProductCategory.Items.Add("Limpeza");
                CBProductCategory.Items.Add("Ferragens");
                CBProductCategory.Items.Add("Bricolage");
                CBProductCategory.Items.Add("Automóveis");
            }

            //Limpa o que ficou antes
            TBProductName.Clear();
            TBProductQuantity.Clear();
            CBProductCategory.SelectedItem = null;
            CBProductUnity.SelectedItem = null;
        }

        private void BTCreateProduct2_Click(object sender, RoutedEventArgs e)
        {
            //ListsItens
            LabelLists.Visibility = Visibility.Visible;
            BTAddList.Visibility = Visibility.Visible;
            LVLists.Visibility = Visibility.Visible;
            CBLists.Visibility = Visibility.Visible;
            BTRemoveProduct.Visibility = Visibility.Visible;
            LabelNomeLista.Visibility = Visibility.Hidden;
            TBAddList.Visibility = Visibility.Hidden;
            BTReadFile.Visibility = Visibility.Visible;
            BTCreateProduct.Visibility = Visibility.Visible;
            BTSave.Visibility = Visibility.Visible;
            BTBackToLogin.Visibility = Visibility.Visible;
            BTDeleteList.Visibility = Visibility.Visible;



            //NewProductItens
            LabelNewProduct.Visibility = Visibility.Hidden;
            TBProductName.Visibility = Visibility.Hidden;
            CBProductUnity.Visibility = Visibility.Hidden;
            CBProductCategory.Visibility = Visibility.Hidden;
            BTCreateProduct2.Visibility = Visibility.Hidden;
            TBProductQuantity.Visibility = Visibility.Hidden;

            //Criar o produto
            Produto newproduct = new Produto();
            newproduct.Nome = TBProductName.Text;
            newproduct.Quantidade = TBProductQuantity.Text;
            newproduct.Categoria = CBProductCategory.Text;
            newproduct.TipoUnidade = CBProductUnity.Text;

            //Vejo a lista que está selecionada na combobox
            string nomeLista = CBLists.Text;
            app.M_Listas.AddProduct(newproduct, nomeLista);
            app.M_Listas.AddProducttoProducts(newproduct);

            RefreshList();

        }




        //Adicionar Categoria
        private void BTAddCategorie_Click(object sender, RoutedEventArgs e)
        {

            LabelCategories.Visibility = Visibility.Hidden;
            BTAddCategorie.Visibility = Visibility.Hidden;
            LBCategories.Visibility = Visibility.Hidden;
            BTRemoveCategory.Visibility = Visibility.Hidden;
            BTEditCategory.Visibility = Visibility.Hidden;
            BTSaveCategory.Visibility = Visibility.Hidden;
            BTAddCategory_2.Visibility = Visibility.Visible;
            LabelNomeCategoria.Visibility = Visibility.Visible;
            TBAddCategorie.Visibility = Visibility.Visible;
            BTEditCategory_2.Visibility = Visibility.Hidden;
            BTBackToLogin.Visibility = Visibility.Hidden;
            BTDeleteList.Visibility = Visibility.Hidden;

            //Limpa o que ficou antes
            TBAddCategorie.Clear();
        }

        //Adicionar Lista

        private void TBAddList_KeyDown(object sender, KeyEventArgs e)
        {
            //O que acontece quando a tecla enter é pressionada para adicionar a lista
            if (e.Key == Key.Enter)
            {
                LabelNomeLista.Visibility = Visibility.Hidden;
                TBAddList.Visibility = Visibility.Hidden;
                LVLists.Visibility = Visibility.Visible;

                string name;
                name = TBAddList.Text;
                app.M_Listas.NewList(name);
                CarregaListasCB();
            }
        }
        private void BTAddList_Click(object sender, RoutedEventArgs e)
        {
            LVLists.Visibility = Visibility.Hidden;
            LabelNomeLista.Visibility = Visibility.Visible;
            TBAddList.Visibility = Visibility.Visible;
            BTDeleteList.Visibility = Visibility.Visible;


            TBAddList.Clear();

        }

        //Settings
        private void BTChangeUsername_Click(object sender, RoutedEventArgs e)
        {
            //-----------------------------------------------------------------------------------------------------------------------------
            //Colocar o que faz
        }

        private void TBAddCategorie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BTAddCategory_2_Click(sender, e);
            }
        }



        //Lê ficheiro XML
        private void BTReadFile_Click(object sender, RoutedEventArgs e)
        {
            //Pede para escolher o ficheiro
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == true)
            {
                stream = dlg.FileName;
                app.M_Listas.CarregaListas(dlg.FileName);
                app.M_Listas.CarregaProdutos(dlg.FileName);
                app.M_Listas.CarregaCategorias(dlg.FileName);
                CarregaListasCB();
            }
            buttonwasclicked = true;

        }

        private void CBLists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            dynamic name = CBLists.SelectedItem;

            foreach(Lista lst in app.M_Listas.Listas)
            {
                if(lst.Nome == name)
                {
                    novalista = lst;
                    LVLists.Items.Clear();
                    foreach (Produto p in novalista.ListProd)
                    {
                        LVLists.Items.Add(p);
                    }
                }
            }
        }

        private void BTRemoveCategory_Click(object sender, RoutedEventArgs e)
        {
            dynamic nomecat = LBCategories.SelectedItem;
            string nome = nomecat;
            Categoria categoria = app.M_Listas.Categorias.Find(C => C.Nome.Equals(nome));
            app.M_Listas.Categorias.Remove(categoria);
            app.M_Listas.SaveList(stream);
            CarregaCategoriasLB();
        }

        private void BTEditCategory_Click(object sender, RoutedEventArgs e)
        {
            LabelCategories.Visibility = Visibility.Hidden;
            BTAddCategorie.Visibility = Visibility.Hidden;
            LBCategories.Visibility = Visibility.Hidden;
            BTRemoveCategory.Visibility = Visibility.Hidden;
            BTEditCategory.Visibility = Visibility.Hidden;
            BTSaveCategory.Visibility = Visibility.Hidden;
            LabelEdiitarCategoria.Visibility = Visibility.Visible;
            TBEditCategorie.Visibility = Visibility.Visible;
            BTEditCategory_2.Visibility = Visibility.Visible;
            BTDeleteList.Visibility = Visibility.Hidden;
        }

        

        private void BTRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            if(LVLists.SelectedItem != null)
            {
                dynamic prod = LVLists.SelectedItem;
                string nomeprod = prod.Nome;
                dynamic namelist = CBLists.SelectedItem;

                novalista.Nome = namelist;
                novalista = app.M_Listas.CopyList(novalista);

                Produto product = novalista.ListProd.Find(L => L.Nome.Equals(nomeprod));

                novalista.RemoveProductList(prod);
                app.M_Listas.Produtos.Remove(prod);

                RefreshList();
            }
        }

        private void BTSaveCategory_Click(object sender, RoutedEventArgs e)
        {
            app.M_Listas.SaveList(stream);
        }

        private void BTSave_Click(object sender, RoutedEventArgs e)
        {
            app.M_Listas.SaveList(stream);
        }

        private void BTAddCategory_2_Click(object sender, RoutedEventArgs e)
        {
            app.M_Listas.AdicionarCategoria(TBAddCategorie.Text);
            app.M_Listas.SaveList(stream);

            CarregaCategoriasLB();
            
            LabelCategories.Visibility = Visibility.Visible;
            BTAddCategorie.Visibility = Visibility.Visible;
            LBCategories.Visibility = Visibility.Visible;
            BTRemoveCategory.Visibility = Visibility.Visible;
            BTEditCategory.Visibility = Visibility.Visible;
            BTSaveCategory.Visibility = Visibility.Visible;
            BTAddCategory_2.Visibility = Visibility.Hidden;
            //---------------------------------------- Adicionar o que falta
            LabelNomeCategoria.Visibility = Visibility.Hidden;
            TBAddCategorie.Visibility = Visibility.Hidden;
            LabelEdiitarCategoria.Visibility = Visibility.Hidden;
            TBEditCategorie.Visibility = Visibility.Hidden;
            BTEditCategory_2.Visibility = Visibility.Hidden;


        }

        private void TBEditCategorie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LabelEdiitarCategoria.Visibility = Visibility.Hidden;
                TBEditCategorie.Visibility = Visibility.Hidden;
                BTEditCategory_2_Click(sender, e);
            }
        }

        private void BTEditCategory_2_Click(object sender, RoutedEventArgs e)
        {
            dynamic nomecat = LBCategories.SelectedItem;
            string nome = nomecat;
            Categoria categoria = app.M_Listas.Categorias.Find(C => C.Nome.Equals(nome));
            app.M_Listas.Categorias.Remove(categoria);
            app.M_Listas.AdicionarCategoria(TBEditCategorie.Text);
            app.M_Listas.SaveList(stream);
            CarregaCategoriasLB();

            LabelCategories.Visibility = Visibility.Visible;
            BTAddCategorie.Visibility = Visibility.Visible;
            LBCategories.Visibility = Visibility.Visible;
            BTRemoveCategory.Visibility = Visibility.Visible;
            BTEditCategory.Visibility = Visibility.Visible;
            BTSaveCategory.Visibility = Visibility.Visible;
            LabelEdiitarCategoria.Visibility = Visibility.Hidden;
            TBEditCategorie.Visibility = Visibility.Hidden;
            BTEditCategory_2.Visibility = Visibility.Hidden;
            BTBackToLogin.Visibility = Visibility.Hidden;
        }

        private void BTDeleteList_Click(object sender, RoutedEventArgs e)
        {
            dynamic name = CBLists.SelectedItem;

            foreach (Lista lst in app.M_Listas.Listas)
            {
                if (lst.Nome == name)
                {
                    novalista = lst;
                    LVLists.Items.Clear();
                    foreach (Produto p in novalista.ListProd)
                    {
                        LVLists.Items.Remove(p);
                    }
                }
            }
            app.M_Listas.RemoveList(name);
            CarregaListasCB();
        }

        private void BTBackToLogin_Click(object sender, RoutedEventArgs e)
        {
            //Window voltar = new Window();
            //MainWindow();
            //this.Hide();
            // voltar.Show();
            MainWindow voltar = new MainWindow();
            this.Close();
            voltar.ShowDialog();
           
        }

        private void BTChangeEdits_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
