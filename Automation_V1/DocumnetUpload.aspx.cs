using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Automation_V1
{
    public partial class DocumentUpload : System.Web.UI.Page
    {
        general gen = new general();

       protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtContractnumber.Value = Request.QueryString["cid"];
                BindGrid();
            }
        }

        private void BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select contractdocumentid, documenturl from tblcontractdocument where contractid='" + txtContractnumber.Value + "'";
                    cmd.Connection = con;
                    con.Open();
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    con.Close();
                    if (GridView1.Rows.Count > 0)
                    {
                        btnAgree.Enabled = true;
                        HyperLink1.Visible= true;
                        //btnSampleVideo.Enabled = true;
                    }
                }
            }
        }

        protected void Upload(object sender, EventArgs e)
        {
            int max = 1;
            string getscalar = gen.scalar_result("select max(contractdocumentid) from tblcontractdocument");
            max = gen.checkmax(getscalar);

            string ext = Path.GetExtension(FileUpload1.PostedFile.FileName);
            string filename = ddlDocType.SelectedItem.Text + ext;
            string contentType = FileUpload1.PostedFile.ContentType;
            int contractid = Convert.ToInt32(txtContractnumber.Value);
            string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int stat = 1; 
            using (Stream fs = FileUpload1.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);
                    string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {

                       // contractid , documenttype - type pdf or jpg , documenturl -- document name , document - file 
                        string query = "insert into tblcontractdocument values (@contractdocumentid,@contractid,@documenttype,@documenturl,@document, @createdat,@updatedat,@status)";
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@contractdocumentid", max);
                            cmd.Parameters.AddWithValue("@contractid", contractid);
                            cmd.Parameters.AddWithValue("@documenttype", contentType);
                            cmd.Parameters.AddWithValue("@documenturl", filename);
                            cmd.Parameters.AddWithValue("@document", bytes);
                            cmd.Parameters.AddWithValue("@createdat", datetime);
                            cmd.Parameters.AddWithValue("@updatedat", datetime);
                            cmd.Parameters.AddWithValue("@status", stat);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }
           
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void Upload1(object sender, EventArgs e)
        {
            int max = 1;
            string getscalar = gen.scalar_result("select max(contractdocumentid) from tblcontractdocument");
            max = gen.checkmax(getscalar);

            string ext = Path.GetExtension(FileUpload2.PostedFile.FileName);
            string filename = "Video" + ext;
            string contentType = FileUpload2.PostedFile.ContentType;
            int contractid = Convert.ToInt32(txtContractnumber.Value);
            string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int stat = 1;
            using (Stream fs = FileUpload2.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);
                    string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {

                        // contractid , documenttype - type pdf or jpg , documenturl -- document name , document - file 
                        string query = "insert into tblcontractdocument values (@contractdocumentid,@contractid,@documenttype,@documenturl,@document, @createdat,@updatedat,@status)";
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@contractdocumentid", max);
                            cmd.Parameters.AddWithValue("@contractid", contractid);
                            cmd.Parameters.AddWithValue("@documenttype", contentType);
                            cmd.Parameters.AddWithValue("@documenturl", filename);
                            cmd.Parameters.AddWithValue("@document", bytes);
                            cmd.Parameters.AddWithValue("@createdat", datetime);
                            cmd.Parameters.AddWithValue("@updatedat", datetime);
                            cmd.Parameters.AddWithValue("@status", stat);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }

            BindGrid();
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
            sendemail();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Document Submitted for Validation');", true);
        }

        protected void btnAgree_Click(object sender, EventArgs e)
        {
            FileUpload2.Visible = true;
            btnUploadVideo.Visible = true;
            btnSubmit.Visible = true;   
        }

        public void sendemail()
        {
            string userEmail = gen.senderEmail;
            string userCC = "";
            string userBCC = "";
            string strSubject = "";
            string Body = "";

            string str = " select distinct a.contactname from tblcontractdetails as b inner join tblcontract as a on a.contractid = b.contractid where b.contractdetailsid = '" + txtContractnumber.Value + "'";
            DataSet ds = gen.Get_Recordset(str, "mst_group");

            strSubject = "Video Uploaded Completed by " + ds.Tables[0].Rows[0][0].ToString() + "";

            string strBody = "";
            strBody = strBody + "<body >";

            strBody = strBody + "<table style='display: block; font-family: sans-serif;'>";
            strBody = strBody + "<tbody>";
            strBody = strBody + "<tr>";
            strBody = strBody + "<td>Video Document Upload completed" + ds.Tables[0].Rows[0][0].ToString() + "</td>";
            strBody = strBody + "</tr>";

            strBody = strBody + "</tbody>";
            strBody = strBody + " </table>";

            Body = strBody;

            string sendEmail = gen.DoSendEmail(userEmail, userCC, userBCC, strSubject, Body);


        }

        //protected void btnSampleVideo_Click(object sender, EventArgs e)
        //{
        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Hello, my name is [Your Full Name]. I am [your age/role, if relevant], and I am here to provide my identification details as requested.\r\n\r\nIdentification Information:\r\n\r\n    Full Name: [Your Full Name]\r\n    Date of Birth: [Your Date of Birth]\r\n    Identification Type: [Type of ID - e.g., Passport, National ID, Driver’s License]\r\n    ID Number: [Your ID Number]\r\n    Issued By: [Authority that issued the ID]\r\n    Issue Date: [Issue Date of the ID]\r\n    Expiration Date: [Expiration Date of the ID]\r\n    Nationality: [Your Nationality] (if applicable) ');", true);

           

        //}
    }
}