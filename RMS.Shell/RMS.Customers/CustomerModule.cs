using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Customers
{
    public class CustomerModule : IModule
    {
        private readonly IRegionManager regionManager;

        public CustomerModule(IRegionManager regionManager) {

            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.CustomerIcon));
        }
    }
}
