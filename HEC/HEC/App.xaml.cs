using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HEC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        ControllerManager manager;

        public App()
        {
        }

        private void AppStart(object sender, StartupEventArgs e)
        {
            manager = new ControllerManager();
            manager.listenForControllerInput();
            manager.listenForActiveWindow();

            HomeBase homeBase = new HEC.HomeBase();
            homeBase.Show();
        }
    }
}
