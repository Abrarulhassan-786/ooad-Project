using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSooad
{
    class ViewVehicalControl
    {
        public ViewVehicalControl()
        {

        }
        public void transportTypes()
        {
            t_bookingManager tbm =new  t_bookingManager();
            tbm.gettransport();

        }
    }
}
