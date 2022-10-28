using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Sells_Management.DAL;

namespace Sells_Management.BL
{
    class CLS_Login
    {

        public DataTable Login(string ID, string PWD)
        {
            DataAccessLayer DAL = new DataAccessLayer();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("sp_Login", param);
            return dt;

        }
    }
}
