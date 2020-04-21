﻿using Movil.Data;
using Movil.Views.ViewsAcceso;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movil
{
    public partial class App : Application
    {
        static DatabaseQuery database;

        public static DatabaseQuery Database
        {
            get
            {
                if(database == null)
                {
                    database = new DatabaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "prueba.db3"));
                }
                return database;
            }
        }
        

        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
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
