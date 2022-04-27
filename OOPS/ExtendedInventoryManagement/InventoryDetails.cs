using OOPS.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.ExtendedInventoryManagement
{
    public class InventoryDetails
    {
        public List<InventoryManagement> RiceList { get; set; }
        public List<InventoryManagement> WheatList { get; set; }
        public List<InventoryManagement> PulsesList { get; set; }
    }
}