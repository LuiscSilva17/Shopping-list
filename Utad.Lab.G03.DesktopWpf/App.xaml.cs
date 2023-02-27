using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Utad.Lab.G03.Domain.Models;

namespace Utad.Lab.G03.DesktopWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Model M_Listas { get; set; }

        public App()
        {
            M_Listas = new Model();
        }
    }
}
