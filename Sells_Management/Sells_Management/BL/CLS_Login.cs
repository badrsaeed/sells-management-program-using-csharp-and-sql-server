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

            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@ID",SqlDbType.VarChar,50);
            sp[1] = new SqlParameter("@PWD",SqlDbType.VarChar,50);

            sp[0].Value = ID;
            sp[1].Value = PWD;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("sp_Login", sp);
            DAL.Close();

            return dt;

        }
    }
}
