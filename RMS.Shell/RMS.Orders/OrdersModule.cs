using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Orders
{
    public class OrdersModule : IModule
    {
        private readonly IRegionManager regionManager;

        public OrdersModule(IRegionManager regionManager) {

            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.OrdersIcon));
        }
    }
}
