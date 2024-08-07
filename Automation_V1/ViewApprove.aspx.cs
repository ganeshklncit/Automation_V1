using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Automation_V1
{
    public partial class ViewApprove : System.Web.UI.Page
    {
        general gen = new general();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadClient();
            }
        }

        public void loadClient()
        {
            string str = "select * from tblcompany where status = 1";
            DataSet ds = gen.Get_Recordset(str, "tblcompany");

            ddlCompany.DataSource = ds;
            ddlCompany.DataTextField = "companyname";
            ddlCompany.DataValueField = "id";

            ddlCompany.DataBind();
            ddlCompany.Items.Insert(0, new ListItem("Select"));
        }


        public void loadContract()
        {
            string str = "select contractid,contactname from tblcontract where status = 1 and companyid=" + ddlCompany.SelectedItem.Value + "";
            DataSet ds = gen.Get_Recordset(str, "tblcontract");

            ddlContract.DataSource = ds;
            ddlContract.DataTextField = "contactname";
            ddlContract.DataValueField = "contractid";

            ddlContract.DataBind();
            ddlContract.Items.Insert(0, new ListItem("Select"));
        }

        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadContract();
        }

        protected void ddlContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select contractdocumentid, documenturl from tblcontractdocument where contractid='" + ddlContract.SelectedItem.Value + "'";
                    cmd.Connection = con;
                    con.Open();
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    con.Close();
                }
            }
        }

        protected void DownloadFile(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select documenturl, document, documenttype from tblcontractdocument where contractdocumentid=@Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["document"];
                        contentType = sdr["documenttype"].ToString();
                        fileName = sdr["documenturl"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string str = "update tblcontractdocument set updatedat = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',status = '2' where contractid = '" + ddlContract.SelectedItem.Value + "'";
            int result = gen.insert_value(str);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Document Verified Succesfully');", true);
        }
    }
}