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
    public partial class ViewRecordUi : Form
    {
        private V_ViewControl vControl;
        V_InventryManager userinventry;
        public ViewRecordUi()
        {
            string connectionString = "Data Source=ABRAR-LAPTOP;Initial Catalog=TransportData;Integrated Security=True";
            userinventry = new V_InventryManager(connectionString);
            vControl = new V_ViewControl(userinventry);
            InitializeComponent();
        }

        private void ViewRecordUi_Load(object sender, EventArgs e)
        {

        }

        private void btnViewUdata_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //----Call ui of main page and hide this page---
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //----Call ui of Manage Data ui, show and hide this page---
            ManagDataUi mgui = new ManagDataUi();
            mgui.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int regint = Convert.ToInt32(txt1.Text);
            string name = txt2.Text;
            string vehtype = txt3.Text;
            int chrgtext = Convert.ToInt32(txt4.Text);

            userinventry.RegNo = regint;
            userinventry.UserName = name;
            userinventry.VehicalType = vehtype;
            userinventry.charges = chrgtext;
            vControl.createUser();
            MessageBox.Show("User created successfully", "Success");

            //--Fro clearing text box 
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";

            //V_InventryManager imnager = new V_InventryManager();
            //imnager.RegNo = regint;
            //imnager.UserName = txt2.Text;
            //imnager.VehicalType = txt3.Text;
            //imnager.charges = chrgtext;
            //V_ViewControl vocn = new V_ViewControl();
            //vocn.ViewRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
