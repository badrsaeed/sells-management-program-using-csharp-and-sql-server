using Sells_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Sells_Management.BL
{
    internal class CLS_Customers
    {
        public DataTable GetAllCustomers()
        {
            
                DataAccessLayer DAL = new DataAccessLayer();
                DAL.Open();
                DataTable dt = new DataTable();

                //SqlParameter[] parameters = new SqlParameter[6];
                //parameters[0] = new SqlParameter("@ID", SqlDbType.Int);
                //parameters[1] = new SqlParameter("@Fname", SqlDbType.VarChar,25);
                //parameters[2] = new SqlParameter("@Lname", SqlDbType.VarChar,25);
                //parameters[3] = new SqlParameter("@Tel", SqlDbType.NChar, 25);
                //parameters[4] = new SqlParameter("@Email", SqlDbType.VarChar,25);
                //parameters[5] = new SqlParameter("@Image", SqlDbType.Image);

                //parameters[0].Value = customerId;
                //parameters[1].Value = Fname;
                //parameters[2].Value = Lname;
                //parameters[3].Value = telephone;
                //parameters[4].Value = email;
                //parameters[5].Value = image;

                dt = DAL.SelectData("GET_ALL_CUSTOMERS", null);
                DAL.Close();

                return dt;
       }

        public void AddCustomer(string Fname, string Lname,
            string telephone, string email, byte[] image)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@Fname", SqlDbType.VarChar, 25);
            parameters[1] = new SqlParameter("@Lname", SqlDbType.VarChar, 25);
            parameters[2] = new SqlParameter("@Tel", SqlDbType.NChar, 25);
            parameters[3] = new SqlParameter("@Email", SqlDbType.VarChar, 25);
            parameters[4] = new SqlParameter("@Image", SqlDbType.Image);

            parameters[0].Value = Fname;
            parameters[1].Value = Lname;
            parameters[2].Value = telephone;
            parameters[3].Value = email;
            parameters[4].Value = image;

            DAL.ExecuteCommand("Add_Customer", parameters);
            DAL.Close();
        }
    }
}
