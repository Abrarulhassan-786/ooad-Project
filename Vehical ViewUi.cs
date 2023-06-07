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
    public partial class Vehical_View : Form
    {
        public Vehical_View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewVehicalControl vvuc = new ViewVehicalControl();
            vvuc.transportTypes();
            leb1.Text = "Car";
            leb2.Text = "Mazda";
            leb3.Text = "Crain";
            leb4.Text = "Bus";
            leb5.Text = "Train";
            leb6.Text = "Truck";

        }

        private void Vehical_View_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
