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
    public partial class manaFinacailUI : Form
    {
        //-----Calling Class of Manage Financialcontrol class in manafinancial UI-----
        //ManageFinaciaControl mfc = new ManageFinaciaControl();
        private M_ManageControl fmanagerControl;
        financialManager finmanger;
        //Form1 f = new Form1();
        public manaFinacailUI()
        {
            string connectionString = "Data Source=ABRAR-LAPTOP;Initial Catalog=managefinancial;Integrated Security=True";
            finmanger = new financialManager(connectionString);
            fmanagerControl = new M_ManageControl(finmanger);
            InitializeComponent();
        }

        private void manaFinacailUI_Load(object sender, EventArgs e)
        {
            //--- dependecy use and call method add payment--- 
            //mfc.paymentAdd();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //----Call ui of main page and hide this page---
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //---value take from user and insert into made variable 
            string custname = textBox1.Text;
            string companyName = textBox2.Text;
            int amount = Convert.ToInt32(textBox3.Text);
            string payment = textBox4.Text;

            finmanger.cname = custname;
            finmanger.company = companyName;
            finmanger.amount = amount;
            finmanger.mehodPayment = payment;

            //------Controler Object Call ---
            fmanagerControl.SaveDataPayment();
            MessageBox.Show("Data Inserted SucessFully");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
    }
}
