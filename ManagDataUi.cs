using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSooad
{
    public partial class ManagDataUi : Form
    {
        string RegNo = "4";
        string name = "Abrar";
        string Vehical = "Mazda";
        string Charges = "500";
        //M_ManageControl mmc = new M_ManageControl();

        public ManagDataUi()
        {
            InitializeComponent();
        }

        private void ManagDataUi_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ManageFinaciaControl mangc = new ManageFinaciaControl();
            mangc.DisplayData();
            leb1.Text = RegNo;
            leb2.Text = name;
            leb3.Text = Vehical;
            leb4.Text = Charges;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
