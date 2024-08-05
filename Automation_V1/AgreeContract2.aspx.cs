using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Automation_V1
{
    public partial class AgreeContract2 : System.Web.UI.Page
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
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Contract agreed Succesfully');", true);

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please check the Checkbox before Accept');", true);
            }
  
            
        }
    }
}