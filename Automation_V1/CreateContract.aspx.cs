using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
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
            string str = "update tblcontract set amount = '" + txtAmount.Text + "' , createdat = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', updatedat = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'  where companyid =" + ddlCompany.SelectedItem.Value + " and contractid =" + txtContactName.SelectedItem.Value;

            int max = Convert.ToInt32(txtContactName.SelectedItem.Value);

            int result = gen.insert_value(str);

            if (chkcontract1.Checked)
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
            if (chkcontract7.Checked)
            {
                insertContract(max, chkcontract7.Text);
            }
            if (chkcontract8.Checked)
            {
                insertContract(max, chkcontract8.Text);
            }
            if (chkcontract9.Checked)
            {
                insertContract(max, chkcontract9.Text);
            }
            if (chkcontract10.Checked)
            {
                insertContract(max, chkcontract10.Text);
            }
            if (chkcontract11.Checked)
            {
                insertContract(max, chkcontract11.Text);
            }
            if (chkcontract12.Checked)
            {
                insertContract(max, chkcontract12.Text);
            }
            if (chkcontract13.Checked)
            {
                insertContract(max, chkcontract13.Text);
            }
            if (chkcontract14.Checked)
            {
                insertContract(max, chkcontract14.Text);
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Company Contract Created Succesfully');", true);

            Response.Redirect("CreateContract");
        }

        public void insertContract(int contractid, string contract)
        {
            string getscalar = gen.scalar_result("select max(contractdetailsid) from tblcontractdetails");
            int max = gen.checkmax(getscalar);
            string str = "insert into tblcontractdetails values (" + max + "," + contractid + ",'" + contract + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','1')";
            int result = gen.insert_value(str);

            string userEmail = txtemail.Text;
            string userCC = "";
            string userBCC = "";
            string strSubject = "";
            string Body = "";

            strSubject = "Request you to accept the Contract " + contract + "";

            string strBody = "";
            strBody = strBody + "<body >";

            strBody = strBody + "<table style='display: block; font-family: sans-serif;'>";
            strBody = strBody + "<tbody>";
            strBody = strBody + "<tr>";
            strBody = strBody + "<td>Contract Created by Automation team, Please accept the contract by click the below url</td>";
            strBody = strBody + "</tr>";
            if (contract == "CIC accounts")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/CIC-accounts?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Corporation Tax")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/corporation_tax?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "General Terms and Conditions All Clients")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/general_terms_conditions_all_clients?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "LLP Accounts")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/LLP_accounts?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Partnership accounts preperation")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/partnership_accounts_preparation?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Payroll Services")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/payroll_services?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "SCIO Charity accounts")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/SCIO_charity_accounts?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Sole Trader accounts Preperation")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/sole_trader_accounts_preparation?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Unicorporated Charity accounts receipts Payments")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/unicorporated_charity_accounts_receipts_payments?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Unicorporated Charity accounts accruals")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/unincorporated_charity_accounts_accruals?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "unregistred club accounts")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/unregistered_club_account?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "VAT")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/vat?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Limited Company Charity accouts")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/limited_company_charity_accounts?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Limited Company Statuory accounts preperation")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/limited_company_statutory_accounts_preparation?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }

            strBody = strBody + "</tbody>";
            strBody = strBody + " </table>";

            Body = strBody;

            string sendEmail = gen.DoSendEmail(userEmail, userCC, userBCC, strSubject, Body);

        }
        
        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
           loadContract();
        }

        public void loadContract()
        {
            string str = "select contractid,contactname from tblcontract where companyid=" + ddlCompany.SelectedItem.Value + "";
            DataSet ds = gen.Get_Recordset(str, "tblcontract");

            txtContactName.DataSource = ds;
            txtContactName.DataTextField = "contactname";
            txtContactName.DataValueField = "contractid";

            txtContactName.DataBind();
            txtContactName.Items.Insert(0, new ListItem("Select"));
        }

        protected void btnSendVideoLink_Click(object sender, EventArgs e)
        {
            string str = "select * from tblcontract where companyid = '" + ddlCompany.SelectedItem.Value + "' and contractid = '" + txtContactName.SelectedItem.Value + "'";
            DataSet ds = gen.Get_Recordset(str, "mst_group");

            if (ds.Tables[0].Rows.Count != 0)
            {
                string userEmail = txtemail.Text;
                string userCC = "";
                string userBCC = "";
                string strSubject = "";
                string Body = "";

                strSubject = "Request you to upload the Validation Document for Company" + ddlCompany.SelectedItem.Text + "";

                string strBody = "";
                strBody = strBody + "<body >";

                strBody = strBody + "<table style='display: block; font-family: sans-serif;'>";
                strBody = strBody + "<tbody>";
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>Contract Created by Automation team, Please accept the contract by click the below url</td>";
                strBody = strBody + "</tr>";

                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://www.thymepm.tax/DocumnetUpload?cid=" + ds.Tables[0].Rows[0][0].ToString() + "</td>";
                strBody = strBody + "</tr>";

                strBody = strBody + "</tbody>";
                strBody = strBody + " </table>";

                Body = strBody;

                string sendEmail = gen.DoSendEmail(userEmail, userCC, userBCC, strSubject, Body);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Document Upload Link Sent Succesfully');", true);

                Response.Redirect("CreateContract");

            }

        }

        protected void btnEmployee_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateEmployee");
        }

        protected void txtContactName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from tblcontract where companyid =" + ddlCompany.SelectedItem.Value + " and contractid =" + txtContactName.SelectedItem.Value;
            DataSet ds = gen.Get_Recordset(str, "mst_group");

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtAmount.Text = ds.Tables[0].Rows[0][3].ToString();
                txtemail.Text = ds.Tables[0].Rows[0][2].ToString();

                string strDetails = "select * from tblcontractdetails where contractid =" + ds.Tables[0].Rows[0][0].ToString();
                DataSet dsDetails = gen.Get_Recordset(strDetails, "mst_group");

                if (dsDetails.Tables[0].Rows.Count != 0)
                {
                    for (int i = 0; i < dsDetails.Tables[0].Rows.Count; i++)
                    {
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "CIC accounts")
                        {
                            chkcontract1.Checked = true;

                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl1.Visible = true;
                                lbl1.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl1.Visible = true;
                                lbl1.Text = "Accepted";
                            }
                        }
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Corporation Tax")
                        {
                            chkcontract2.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl2.Visible = true;
                                lbl2.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl2.Visible = true;
                                lbl2.Text = "Accepted";
                            }
                        }
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "General Terms and Conditions All Clients")
                        {
                            chkcontract3.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl3.Visible = true;
                                lbl3.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl3.Visible = true;
                                lbl3.Text = "Accepted";
                            }
                        }
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "LLP Accounts")
                        {
                            chkcontract4.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl4.Visible = true;
                                lbl4.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl4.Visible = true;
                                lbl4.Text = "Accepted";
                            }
                        }
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Partnership accounts preperation")
                        {
                            chkcontract5.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl5.Visible = true;
                                lbl5.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl5.Visible = true;
                                lbl5.Text = "Accepted";
                            }
                        }
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Payroll Services")
                        {
                            chkcontract6.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl6.Visible = true;
                                lbl6.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl6.Visible = true;
                                lbl6.Text = "Accepted";
                            }
                        }

                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "SCIO Charity accounts")
                        {
                            chkcontract7.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl7.Visible = true;
                                lbl7.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl7.Visible = true;
                                lbl7.Text = "Accepted";
                            }
                        }


                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Sole Trader accounts Preperation")
                        {
                            chkcontract8.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl8.Visible = true;
                                lbl8.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl8.Visible = true;
                                lbl8.Text = "Accepted";
                            }
                        }


                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Unicorporated Charity accounts receipts Payments")
                        {
                            chkcontract9.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl9.Visible = true;
                                lbl9.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl9.Visible = true;
                                lbl9.Text = "Accepted";
                            }
                        }

                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Unicorporated Charity accounts accruals")
                        {
                            chkcontract10.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl10.Visible = true;
                                lbl10.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl10.Visible = true;
                                lbl10.Text = "Accepted";
                            }
                        }

                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "unregistred club accounts")
                        {
                            chkcontract11.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl11.Visible = true;
                                lbl11.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl11.Visible = true;
                                lbl11.Text = "Accepted";
                            }
                        }


                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "VAT")
                        {
                            chkcontract12.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl12.Visible = true;
                                lbl12.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl12.Visible = true;
                                lbl12.Text = "Accepted";
                            }
                        }


                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Limited Company Charity accouts")
                        {
                            chkcontract13.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl13.Visible = true;
                                lbl13.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl13.Visible = true;
                                lbl13.Text = "Accepted";
                            }
                        }


                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Limited Company Statuory accounts preperation")
                        {
                            chkcontract14.Checked = true;
                            if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 1)
                            {
                                lbl14.Visible = true;
                                lbl14.Text = "Waiting for approval";
                            }
                            else if (Convert.ToInt32(dsDetails.Tables[0].Rows[i][5]) == 2)
                            {
                                lbl14.Visible = true;
                                lbl14.Text = "Accepted";
                            }
                        }
                    }
                }
            }
        }
    }
}