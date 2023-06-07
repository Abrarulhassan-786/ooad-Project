using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TMSooad
{
    class V_InventryManager
    {
        //-------initiliza the Variable --------
        public int RegNo;
        public  string UserName;
        public string VehicalType;
        public int charges;
        private string connectionstring;
   


        //-------create default Constructor-------
        public V_InventryManager()
        {
            
        }
        //--- one value constructor ----- as Connection String
        public V_InventryManager(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        //-------create Contructor for User Data-------
        //public V_InventryManager(int Reg,string name, string vehty,int charg)
        //{
        //    RegNo = Reg;
        //    UserName = name;
        //    VehicalType = vehty;
        //    charges = charg;
        //}

        //----Create SaveData method in V_Inventry Manager entity Class-------
        public void saveData()
        {
            //------Sql Query of Insert----------
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "INSERT INTO record (Registration, userName,VehicalType,Charges) VALUES (@registration, @username, @VehType, @charge)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@registration",RegNo);
                command.Parameters.AddWithValue("@username", UserName);
                command.Parameters.AddWithValue("@VehType", VehicalType);
                command.Parameters.AddWithValue("@charge", charges);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void dataDisplay()
        {
            MessageBox.Show("Congrats Data Displayed SucessFully");

        }
    } 
}
