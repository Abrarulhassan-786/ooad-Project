using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSooad
{
    class V_ViewControl
    {
        private V_InventryManager inventryManager;
        public V_ViewControl(V_InventryManager inventryManager)
        {
            this.inventryManager = inventryManager;
        }

        //ViewRecordUi vu = new ViewRecordUi();
        //-----Create Method of "VIEW Record" in control class V_ViewControl------


        public void createUser()
        {
            inventryManager.saveData();
        }
    }
}
