using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RMS.Shell
{
    public class Bootstrapper : UnityBootstrapper
    {

        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(Accounts.AccountsModule));
            moduleCatalog.AddModule(typeof(Customers.CustomerModule));
            moduleCatalog.AddModule(typeof(Orders.OrdersModule));
            moduleCatalog.AddModule(typeof(Stock.StockModule));
            moduleCatalog.AddModule(typeof(TableReservationManagement.TableReservationModule));
        }
    }
}
