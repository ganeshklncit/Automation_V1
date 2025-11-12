using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Automation_V1
{
    public partial class createclient : System.Web.UI.Page
    {
        general gen = new general();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void btnSubmit_Click(System.Object sender, System.EventArgs e)
        {

            // string getscalar = gen.scalar_result("select max(ID) from tblcompany");
            // int max = gen.checkmax(getscalar);

            // string str = "insert into tblcompany values (" + max + ",'" + txtcompanyname.Text + "','1')";
            // int result = gen.insert_value(str);

            //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Company Created Succesfully');", true);

            // If Edit mode: update existing record
            if (ViewState["EditID"] != null)
            {
                int editId = Convert.ToInt32(ViewState["EditID"]);
                string updateSql = "update tblcompany set CompanyName = '" + txtcompanyname.Text + "' where id = " + editId;
                int updateResult = gen.insert_value(updateSql);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Company Updated Successfully');", true);

                // reset edit state
                ViewState.Remove("EditID");
                btnSubmit.Text = "Create Company";
                txtcompanyname.Text = string.Empty;

                BindGrid();
                return;
            }

            // Insert new record (existing behaviour)
            string getscalar = gen.scalar_result("select max(ID) from tblcompany");
            int max = gen.checkmax(getscalar);

            string str = "insert into tblcompany values (" + max + ",'" + txtcompanyname.Text + "','1')";
            int result = gen.insert_value(str);

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Company Created Succesfully');", true);

            txtcompanyname.Text = string.Empty;
            BindGrid();

        }


        private void BindGrid()
        {

            string str = "select * from tblcompany where status = 1";
            DataSet ds = gen.Get_Recordset(str, "mst_group");
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditCompany")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                string str = "select * from tblcompany where id = " + id;
                DataSet ds = gen.Get_Recordset(str, "tblcompany");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    txtcompanyname.Text = dr["CompanyName"].ToString();

                    ViewState["EditID"] = id;
                    btnSubmit.Text = "Update";
                }
            }
        }



    }
}