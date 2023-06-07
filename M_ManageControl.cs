using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSooad
{
    class M_ManageControl
    {
        //----calling class ui manage vehical UI
        //ManagDataUi mdui = new ManagDataUi();
        financialManager finmanger;
        public M_ManageControl(financialManager finmanger)
        {
            this.finmanger = finmanger;
        }
        public void SaveDataPayment()
        {
            finmanger.SavaUserPayment();
        }
    }
}
    
