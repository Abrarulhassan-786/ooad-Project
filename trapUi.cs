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
    public partial class trapUi : Form
    {
        public trapUi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t_CheckTrapControl trapcontol = new t_CheckTrapControl();
            trapcontol.checklist();
            t_bookingManager bmnager = new t_bookingManager();
            leb1.Text = " Beware the 'broken taxi meter'";
            leb2.Text = "Suspiciously helpful bag handlers";
            leb3.Text = "The 'free' trinket routine";
            leb4.Text = "The guilt trip";
            leb5.Text = "Mysterious rental vehicle damage";
            leb6.Text = "Fake money and wrong change";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //----Call ui of main page and hide this page---
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //----Call vehicals Typeclass Calling page and hide this page---
            Vehical_View vehicals = new Vehical_View();
            vehicals.Show();
            this.Hide();
        }
    }
}
