using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Automation_V1
{
    public partial class limited_company_charity_accounts : System.Web.UI.Page
    {
        general gen = new general();

       protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtContractnumber.Value = Request.QueryString["cid"];
            }
        }

        protected void btnSubmit_Click(System.Object sender, System.EventArgs e)
        {
            if (chkContract.Checked)
            {
                string str = "update tblcontractdetails set updatedat = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',status = '2' where contractdetailsid = '" + txtContractnumber.Value + "'";
                int result = gen.insert_value(str);
                sendemail();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Contract agreed Succesfully');", true);

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please check the Checkbox before Accept');", true);
            }
  
            
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

            strSubject = "Contract Accept Request " + ds.Tables[0].Rows[0][0].ToString() + "";

            string strBody = "";
            strBody = strBody + "<body >";

            strBody = strBody + "<table style='display: block; font-family: sans-serif;'>";
            strBody = strBody + "<tbody>";
            strBody = strBody + "<tr>";
            strBody = strBody + "<td>Limited company charity accounts Succefully accepted  by " + ds.Tables[0].Rows[0][0].ToString() + "</td>";
            strBody = strBody + "</tr>";
          
            strBody = strBody + "</tbody>";
            strBody = strBody + " </table>";

            Body = strBody;

            string sendEmail = gen.DoSendEmail(userEmail, userCC, userBCC, strSubject, Body);

            
        }
    }
}