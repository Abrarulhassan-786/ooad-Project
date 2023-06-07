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
    public partial class Form1 : Form
    {
        //---Create Object of ViewRecord Ui Class---
        ViewRecordUi veui = new ViewRecordUi();

        //---Create Object of manaFinancial Ui Class---
        manaFinacailUI mfui = new manaFinacailUI();

        //---Create Object of Trap Ui Class---
        trapUi tui = new trapUi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnim_Click(object sender, EventArgs e)
        {
            //--- Messgae Show Then Go Farward----
            MessageBox.Show("Connected View Record Page ", "SucessFully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //---show the ui of view record Ui---
            veui.Show();
            
            //---Hide this page 
            this.Hide();
        }

        private void btnfm_Click(object sender, EventArgs e)
        {
            //--- Messgae Show Then Go Farward----
            MessageBox.Show("Connected Financial Manager  Page ", "SucessFully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //---show the ui of manage financial Ui---
            mfui.Show();

            //---Hide this page 
            this.Hide();
        }

        private void Btnbm_Click(object sender, EventArgs e)
        {
            //--- Messgae Show Then Go Farward----
            MessageBox.Show("Connected Trap Page ", "SucessFully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //---show the ui of Trip Ui class---
            tui.Show();
            //---Hide this page 
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-----EXIT PROGRAM METHOD
            System.Windows.Forms.Application.Exit();
        }
    }
}
