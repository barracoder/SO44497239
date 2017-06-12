using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.ServiceLocation;
using Prism.Unity;
using StackOverflowScratch.ViewModel.SO44497239;

namespace StackOverflowScratch
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainWindow>();
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();
        }

        protected override void InitializeShell()
        {
            var vm = ServiceLocator.Current.GetInstance<MainViewModel>();
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.DataContext = vm;
            Application.Current.MainWindow.Show();
        }
    }
}
