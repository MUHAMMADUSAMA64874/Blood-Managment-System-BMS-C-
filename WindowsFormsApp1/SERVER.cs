using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class SERVER
    {
        private static string path = @"data source=.\SQLEXPRESS; initial catalog=BLOODDB; integrated security=true";

        //public static DataTable VIEWDATAGRID(string query)
        //{
        //    //SqlConnection con = new SqlConnection(path);
        //    //con.Open();
        //    //SqlCommand cmd = new SqlCommand(query,con);
        //    //SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    //DataTable dt = new DataTable();
        //    //sda.Fill(dt);
        //    //return dt;
        //}

        public static void INSERT(string queryget)
        {

            //SqlConnection con = new SqlConnection(path);
            //con.Open();
            //string query = queryget;
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            //con.Close();
        }

        public static void DELTED(string queryget,int key)
        {
        //    SqlConnection con = new SqlConnection(path);
        //    con.Open();
        //    string query = queryget;
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        }

        public static void UPDATE(string queryget)
        {

            //SqlConnection con = new SqlConnection(path);
            //con.Open();
            //string query = queryget;
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
    }
}
