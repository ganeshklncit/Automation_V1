using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Automation_V1
{
    public class general
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        DataSet ds;
        SqlDataAdapter adp;

        public DataSet Get_Recordset(string strsql, string tablename)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open) con.Close();
                con.Open();
                ds = new DataSet();
                adp = new SqlDataAdapter(strsql, con);
                adp.Fill(ds, tablename);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open) con.Close();
            }
        }

        public int insert_value(string sql1)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open) con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand(sql1, con);
                return (cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open) con.Close();
            }
        }

        public string scalar_result(string strsql)
        {
            // SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["AWOnlineConnectionString"]);
            try
            {
                if (con.State == ConnectionState.Open) con.Close();
                con.Open();

                // string str = "insert into mst_login values(" + maxid + ",'" + txtuserid.Text + "','" + txtpassword.Text + "','D','" + txtname.Text + "')"

                SqlCommand cmd = new SqlCommand(strsql, con);
                string result = Convert.ToString(cmd.ExecuteScalar());

                // if (con.State == ConnectionState.Open) con.Close();

                return (result);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open) con.Close();
            }
        }

        public int checkmax(string strsql)
        {
            // int ds;
            try
            {
                int setmax = 0;

                if (strsql == "")
                {
                    setmax = setmax + 1;
                }
                else
                {
                    setmax = Convert.ToInt32(strsql) + 1;
                }

                return (setmax);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}