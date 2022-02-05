using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace firstform.DataConnection
{
    
    public class SalesmanDBconnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-UANU9MDM;Initial Catalog=Sales;Integrated Security=True";
        public string InsertSalesman(SalesmanModel salesmanModelObj)
        {
            SqlConnection sqlConnectionobj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("insert into Salesman values(" + salesmanModelObj.salesman_id + ",'" + salesmanModelObj.name + ",'" + salesmanModelObj.city +"')", sqlConnectionobj);
            sqlConnectionobj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionobj.Close();
            return "Tutorial details saved successfully";
        }
        public void UpdateSalesman(SalesmanModel salesmanModelObj)
        {

        }
        public void DeleteSalesmanById(int salesmanid)
        {

        }
        public DataTable SelectSalesman()
        {
            SqlConnection sqlConnectionobj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Salesman", sqlConnectionobj);
            sqlConnectionobj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionobj.Close();
            return dt;

        }
        public void EditSalesmanById(int salesmanid)
        {

        }
    }
}