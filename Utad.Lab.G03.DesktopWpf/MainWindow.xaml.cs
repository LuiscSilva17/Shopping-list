using Microsoft.Win32;
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

namespace Utad.Lab.G03.DesktopWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private App app;

        public MainWindow()
        {
            InitializeComponent();
        }


        //Buttons
        private void BTLogin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Não existe ligação ao servidor!", "ERRO", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BTSignUpLogin_Click(object sender, RoutedEventArgs e)
        {   //Abre Janela para fazer o registo
            MyList_SignUp dlg = new MyList_SignUp();
            this.Close();
            dlg.ShowDialog();

        }

        private void BTOffline_Click(object sender, RoutedEventArgs e)
        {
            MyList dlg = new MyList();
            this.Close();
            dlg.ShowDialog();
        }
    }
}
