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
            string str = "select contractid,contactname from tblcontract where companyid=" + ddlCompany.SelectedItem.Value + "";
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
            loadstatus();
        }

        private void BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select contractdocumentid, documenturl,updatedat, status  from tblcontractdocument where contractid='" + ddlContract.SelectedItem.Value + "'";
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
            string str = "update tblcontract set updatedat = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',status = '2' where contractid = '" + ddlContract.SelectedItem.Value + "'";
            int result = gen.insert_value(str);

            str = "update tblcontractdocument set updatedat = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',status = '2' where contractid = '" + ddlContract.SelectedItem.Value + "'";
            result = gen.insert_value(str);

            // send approval email
            try
            {
                SendApprovalEmail();
            }
            catch
            {
                // swallow or log as appropriate; do not break user flow
            }

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Document Verified Succesfully');", true);
        }

        private void SendApprovalEmail()
        {
            string userEmail = gen.senderEmail; // fallback recipient
            string userCC = "";
            string userBCC = "";
            string strSubject = "";
            string Body = "";

            // try to get contact name and email from tblcontract
            string str = "select contactname, emailid from tblcontract where contractid = '" + ddlContract.SelectedItem.Value + "'";
            DataSet ds = gen.Get_Recordset(str, "tblcontract");

            string contactName = "";
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                
                contactName = ds.Tables[0].Rows[0][0].ToString();
                var contactEmailCol = ds.Tables[0].Rows[0][1].ToString();
                if (!string.IsNullOrEmpty(contactEmailCol))
                {
                    userEmail = contactEmailCol;
                }
            }

            strSubject = "Document Approved for Contract " + ddlContract.SelectedItem.Value;
            Body = "<body>";
            Body += "<p>Hi " + contactName + ",</p>";
            Body += "<p>Your document for contract <strong>" + HttpUtility.HtmlEncode(ddlContract.SelectedItem.Value) + "</strong> has been approved on " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ".</p>";
            Body += "<p>Regards,<br/>" + HttpUtility.HtmlEncode(gen.senderEmail) + "</p>";
            Body += "</body>";

            // call shared email helper
            gen.DoSendEmail(userEmail, userCC, userBCC, strSubject, Body);
        }


        public void loadstatus()
        {
            string str = "select contractid,contactname,status,updatedat from tblcontract where contractid=" + ddlContract.SelectedItem.Value + "";
            DataSet ds = gen.Get_Recordset(str, "tblcontract");

            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Visible = true;
                if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1)
                {
                    Label1.Text = "Waiting for approval";
                }
                else if(Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 2)
                {
                    Label1.Text = "Approved on " + ds.Tables[0].Rows[0][3].ToString();
                }
            }
        }
    }
}