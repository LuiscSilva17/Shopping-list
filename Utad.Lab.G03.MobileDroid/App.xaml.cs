using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Utad.Lab.G03.Domain.Models;
using Utad.Lab.G03.MobileDroid.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Montserrat-Bold.ttf",Alias="Montserrat-Bold")]
     [assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat-Medium")]
     [assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat-Regular")]
     [assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat-SemiBold")]
     [assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]
namespace Utad.Lab.G03.MobileDroid
{
    public partial class App : Application
    {
        public static string ImageServerPath { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";

        //mainpage
        public MainPage Page { get; set; }
        

        //Account
        public Change_Profrile C_Profile { get; private set; }
        public Profile_Page Cr_Profile { get; private set; } //CrProfile_Page
        public Edit_Profile E_Profile { get; private set; }
        public ForgotPassword F_Password { get; private set; }
        public Login_Page L_Page { get; private set; }  
        public SignUp S_up { get; private set; }

        //Category
        public Category_List C_List { get; private set; }
        public Create_Category Cr_Category { get; private set; }
        public Edit_Category E_Category { get; private set; }

        //List
        public Create_List Cr_List { get; private set; }
        public Lists List_ { get; private set; }

        //product
        public Create_Product Cr_Product { get; private set; }
        public Edit_Product E_Product { get; private set; }
        public List_Product L_Product { get; private set; }
        public Product Product_ { get; private set; }

        //Settings
        public Settings_Page S_Page { get; private set; }

        //Lista
        public ObservableCollection<Lista> DBLists;
        public ObservableCollection<Produto> DBProducts;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            //Account
            C_Profile = new Change_Profrile();
            Cr_Profile = new Profile_Page();
            E_Profile = new Edit_Profile();
            F_Password = new ForgotPassword();
            L_Page = new Login_Page();
            S_up = new SignUp();

            //Category
            C_List = new Category_List();
            Cr_Category = new Create_Category();
            E_Category = new Edit_Category();

            //List
            Cr_List = new Create_List();
            List_ = new Lists();

            //Product
            Cr_Product = new Create_Product();
            E_Product = new Edit_Product();
            L_Product = new List_Product();
            Product_ = new  Product();

            //Settings
            S_Page = new Settings_Page();

            //Listas
            DBLists = new ObservableCollection<Lista>();
            DBProducts = new ObservableCollection<Produto>();

           
    }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
