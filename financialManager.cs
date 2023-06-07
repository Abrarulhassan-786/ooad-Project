using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TMSooad
{
    class financialManager
    {
        //-----Creating Property ----
        public string cname;
        public string company;
        public int amount;
        public string mehodPayment;
        private string connectionstring;
        //-----Creating Constructor With same name as Financial Manager Class
        public financialManager()
        {

        }
        //-----Creating Constructor With same name as Financial Manager Class and one parameter
        public financialManager(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        //---Creating Customize Constructor ---
        //public financialManager(string cn, string compan, int a, string paymentBy)
        //{
        //    cname = cn;
        //    company = compan;
        //    amount = a;
        //    mehodPayment = paymentBy;
        //}
        //----Creating method of void method is paymentMethod-----
        public void SavaUserPayment()
        {
            //------Sql Query of Insert----------
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "INSERT INTO Fmanger (customerName,companyName,amount,paymentMethod) VALUES (@customerName, @companyName, @amount, @payment)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@customerName", cname);
                command.Parameters.AddWithValue("@companyName", company);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@payment", mehodPayment);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void clearData()
        {

        }
    }
}
