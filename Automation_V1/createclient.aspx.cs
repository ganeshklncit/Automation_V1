using System;
using System.Collections.Generic;
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

        }

        protected void btnSubmit_Click(System.Object sender, System.EventArgs e)
        {
            
                string getscalar = gen.scalar_result("select max(ID) from tblcompany");
                int max = gen.checkmax(getscalar);

                string str = "insert into tblcompany values (" + max + ",'" + txtcompanyname.Text + "','1')";
                int result = gen.insert_value(str);

               ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Company Created Succesfully');", true);
            
        }
    }
}