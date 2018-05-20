using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableReservationManagement
{
    public class TableReservationModule : IModule
    {
        private readonly IRegionManager regionManager;

        public TableReservationModule(IRegionManager regionManager) {

            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.TableReservationItem));
        }
    }
}
