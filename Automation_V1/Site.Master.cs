using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Automation_V1
{
    public partial class SiteMaster : MasterPage
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null)
            {
                // Redirect to login page if session is missing
                Response.Redirect("Login.aspx");
            }

            lblFullName.Text = (String)Session["userid"] + " ! ";
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

    }
}