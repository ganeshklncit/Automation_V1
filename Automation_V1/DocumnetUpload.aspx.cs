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
                }
            }
        }

        protected void Upload(object sender, EventArgs e)
        {
            int max = 1;
            string getscalar = gen.scalar_result("select max(contractdocumentid) from tblcontractdocument");
            max = gen.checkmax(getscalar);
  

            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
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


    }
}