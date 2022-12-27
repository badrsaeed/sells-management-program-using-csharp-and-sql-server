using Microsoft.VisualBasic;
using Sells_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;

namespace Sells_Management.BL
{
    internal class Products
    {
        public DataTable GetAllCategories()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Category_Data", null);
            DAL.Close();
            
            return dt;
            
        }

        public DataTable GetAllProducts()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Get_All_Products", null);
            DAL.Close();

            return dt;
        }
        public DataTable GetProductImage(string id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", SqlDbType.VarChar, 50);
            parameters[0].Value = id;
            dt = DAL.SelectData("Get_Product_image", parameters);
            DAL.Close() ;

            return dt;
        }


        public DataTable SearchAboutProduct(string searchValue)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            parameters[0].Value = searchValue;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SearchAboutProduct", parameters);
            DAL.Close();

            return dt;
        }

        public void UpdateProduct(string product_id, string productDesc, int quentity,
            string price, byte[] image, int CategoryId)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@prod_Id", SqlDbType.VarChar, 30);
            parameters[1] = new SqlParameter("@description", SqlDbType.VarChar, 50);
            parameters[2] = new SqlParameter("@quentity", SqlDbType.Int);
            parameters[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            parameters[4] = new SqlParameter("@image", SqlDbType.Image);
            parameters[5] = new SqlParameter("@cat_id", SqlDbType.Int);
            parameters[0].Value = product_id;
            parameters[1].Value = productDesc;
            parameters[2].Value = quentity;
            parameters[3].Value = price;
            parameters[4].Value = image;
            parameters[5].Value = CategoryId;

            DAL.ExecuteCommand("Update_product", parameters);
            DAL.Close();
        }
        public void DeleteProduct(string productId)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@deleted_Product_ID", SqlDbType.VarChar, 50);
            parameters[0].Value = productId;

            DAL.ExecuteCommand("DeleteProduct", parameters);
        }

        public void AddProduct(string productId, string description,
            int quentity, string price, int categoryId, byte [] image)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter [] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@Id_Category", SqlDbType.Int);
            parameters[1] = new SqlParameter("@Id_Product", SqlDbType.VarChar);
            parameters[2] = new SqlParameter("@Product_decription", SqlDbType.VarChar);
            parameters[3] = new SqlParameter("@Product_Quentity", SqlDbType.Int);
            parameters[4] = new SqlParameter("@Product_Price", SqlDbType.VarChar);
            parameters[5] = new SqlParameter("@Product_Img", SqlDbType.Image);

            parameters[0].Value = categoryId;
            parameters[1].Value = productId;
            parameters[2].Value = description;
            parameters[3].Value = quentity;
            parameters[4].Value = price;
            parameters[5].Value = image;

            DAL.ExecuteCommand("Add_Product", parameters);
            DAL.Close();
        }

        public DataTable ProductIdChecker(string id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@product_Id",SqlDbType.VarChar,50);
            parameters[0].Value = id;

            DataTable dt = DAL.SelectData("VerifayProductID", parameters);
            DAL.Close();

            return dt;
        }
    }
}
