using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSooad
{
    class ManageFinaciaControl
    {
        
        public ManageFinaciaControl()
        {

        }

        public void DisplayData()
        {
            V_InventryManager inventryManger = new V_InventryManager();
            inventryManger.dataDisplay();
        }
    }
}
