using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSooad
{
    class t_bookingManager
    {
        //---trap varibale decalre----
        string trap1;
        string trap2;
        string trap3;
        string trap4;
        string trap5;
        string trap6;

        //---vehical type varibale decalre----
        string vehical1;
        string vehical2;
        string vehical3;
        string vehical4;
        string vehical5;
        string vehical6;


        public t_bookingManager()
        {

        }
        //----Created a no return type method (trapdetail) string----
        public void trapdetail()
        {
            trap1 = "Beware the broken taxi meter";
            trap2 = "The 'free' trinket routine";
            trap3 = "Suspiciously helpful bag handlers";
            trap3 = "The guilt trip";
            trap4 = "Mysterious rental vehicle damage";
            trap5 = "Fake money and wrong change";
            trap6 = "Fake police";
        }
        //----Created a no return type method (gettransport) string----
        public void gettransport()
        {
            vehical1 = "Car";
            vehical2 = "Bus";
            vehical3 = "Truck";
            vehical4 = "Ven";
            vehical5 = "Traolor";
            vehical6 = "Crain";
        }
    }
}
