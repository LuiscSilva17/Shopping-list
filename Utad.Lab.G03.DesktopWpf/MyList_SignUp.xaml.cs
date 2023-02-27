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

namespace Utad.Lab.G03.DesktopWpf
{
    /// <summary>
    /// Interaction logic for MyList_SignUp.xaml
    /// </summary>
    public partial class MyList_SignUp : ChromelessWindow
    {
        public MyList_SignUp()
        {
            InitializeComponent();
        }

        private void BTSignUp_Click(object sender, RoutedEventArgs e)
        { //Abre pagina com o menu
            MessageBox.Show("Não existe ligação ao servidor!", "ERRO", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BTBacktoLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow dlg = new MainWindow();
            this.Close();
            dlg.ShowDialog();
        }
    }
}
