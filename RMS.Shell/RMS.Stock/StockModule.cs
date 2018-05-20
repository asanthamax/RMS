using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Stock
{
    public class StockModule : IModule
    {
        private readonly IRegionManager regionManager;

        public StockModule(IRegionManager regionManager) {

            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.StockIcon)); 
        }
    }
}
