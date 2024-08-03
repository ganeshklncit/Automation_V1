using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Automation_V1
{
    public partial class Login : System.Web.UI.Page
    {
        general gen = new general();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string str = "select * from tbllogin where userid='" + txtUsername.Text + "' and password='" + txtPassword.Text + "' and status = 1";

            DataSet dslogin = gen.Get_Recordset(str, "mst_userlogin");

            if (dslogin.Tables[0].Rows.Count > 0)
            {
                if (dslogin.Tables[0].Rows[0][0].ToString() == "1")
                {
                    Session["userid"] = dslogin.Tables[0].Rows[0][0].ToString();
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}