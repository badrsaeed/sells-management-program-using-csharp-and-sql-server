using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Sells_Management.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlConnection;
        //Const to initialize the Connection to the database
        public DataAccessLayer()
        {
            sqlConnection = new SqlConnection(@"Server=BADR\SQL2019; DataBase=Product_DB; Integrated Security=true");
        }
        //method to open the database server
        public void Open()
        {
            if(sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        //method to Close the database server
        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        //Method To Read Data from DataBase
        public DataTable SelectData(string storedProcedure, SqlParameter [] param)
        {
            // object to take the query and save it
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlConnection;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = storedProcedure;
            //check if the param in empty or has parameters if it has we will store it at sqlcmd
            if (!(param is null))
            {
                for(int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            // object to return the result of query of sqlcmd
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            //object to store the returned Data
            DataTable dt = new DataTable();
            //store the Data in the dt object(Table)
            sqlda.Fill(dt);

            return dt;
        }

        //medthod to alter the data 
        public void ExecuteCommand(string storedProcedure, SqlParameter[] param)
        {
            // object to take the query and save it
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = storedProcedure;
            sqlcmd.Connection = sqlConnection;

            //check if the param in empty or has parameters if it has we will store it at sqlcmd
            if (!(param is null))
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();
        }
    }
}
