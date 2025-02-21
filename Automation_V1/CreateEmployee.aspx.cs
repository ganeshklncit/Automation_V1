using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Automation_V1
{
    public partial class CreateEmployee : System.Web.UI.Page
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
            DataSet ds = gen.Get_Recordset(str, "mst_group");

            ddlCompany.DataSource = ds;
            ddlCompany.DataTextField = "companyname";
            ddlCompany.DataValueField = "id";

            ddlCompany.DataBind();
            ddlCompany.Items.Insert(0, new ListItem("Select"));
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string getscalar = gen.scalar_result("select max(contractid) from tblcontract");
            int max = gen.checkmax(getscalar);

            string str = "insert into tblcontract values (" + max + ",'" + txtContactName.Text + "','" + txtemail.Text + "','','0','0','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','1','" + ddlCompany.SelectedItem.Value + "')";
            int result = gen.insert_value(str);

            Response.Redirect("CreateContract.aspx");
        }

        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}