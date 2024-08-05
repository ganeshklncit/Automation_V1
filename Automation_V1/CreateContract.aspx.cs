using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Automation_V1
{
    public partial class CreateContract : System.Web.UI.Page
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

            string str = "insert into tblcontract values (" + max + ",'" + txtContactName.Text + "','" + txtemail.Text + "','" + txtAmount.Text + "','0','0','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','1')";
            int result = gen.insert_value(str);

            if(chkcontract1.Checked)
            {
                insertContract(max, chkcontract1.Text);
            }
            if (chkcontract2.Checked)
            {
                insertContract(max, chkcontract2.Text);
            }
            if (chkcontract3.Checked)
            {
                insertContract(max, chkcontract3.Text);
            }
            if (chkcontract4.Checked)
            {
                insertContract(max, chkcontract4.Text);
            }
            if (chkcontract5.Checked)
            {
                insertContract(max, chkcontract5.Text);
            }
            if (chkcontract6.Checked)
            {
                insertContract(max, chkcontract6.Text);
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Company Contract Created Succesfully');", true);
        }

        public void insertContract(int contractid , string contract)
        {
            string getscalar = gen.scalar_result("select max(contractdetailsid) from tblcontractdetails");
            int max = gen.checkmax(getscalar);
            string str = "insert into tblcontractdetails values (" + max + ","+ contractid +",'" + contract + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','1')";
            int result = gen.insert_value(str);

        }
    }
}