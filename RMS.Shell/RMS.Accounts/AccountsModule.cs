using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Accounts
{
    public class AccountsModule : IModule
    {
        private readonly IRegionManager regionManager;

        public AccountsModule(IRegionManager regionManager) {

            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.AccountIcon));
        }
    }
}
