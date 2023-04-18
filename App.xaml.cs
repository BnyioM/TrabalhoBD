using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using ITAssetsManagement.Data;
using ITAssetsManagement;

namespace wpf_catalog
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new();

            services.AddDbContext<DbContext>(options =>
            {
                options.UseSqlServer("Data source=BRUNOPC\\SQLEXPRESS; initial catalog=IT_Assets_Management_Relational; user id=sa; pwd=bruno123;");
            });

            services.AddSingleton<MainWindow>();
            serviceProvider = services.BuildServiceProvider();
        }

        private void OnStartup(object s, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();

            mainWindow.Show();
        }
    }
}