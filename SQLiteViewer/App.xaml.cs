using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLiteViewer.Services;
using SQLiteViewer.Views;
using SQLiteViewer.Models;

namespace SQLiteViewer
{
    public partial class App : Application
    {
        static SDatabase database;

        public static SDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new SDatabase();
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            //DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new XamerinFormsDataGridView();
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
