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
            string getscalar = gen.scalar_result("select max(contractid) from tblcontract");
            int max = gen.checkmax(getscalar);

            string str = "insert into tblcontract values (" + max + ",'" + txtContactName.Text + "','" + txtemail.Text + "','" + txtAmount.Text + "','0','0','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','1','" + ddlCompany.SelectedItem.Value + "')";
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
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Company Contract Created Succesfully');", true);
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
            if (contract == "Contract one")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://localhost:44313/AgreeContract1?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Contract Two")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://localhost:44313/AgreeContract2?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Contract Three")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://localhost:44313/AgreeContract3?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Contract Four")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://localhost:44313/AgreeContract4?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Contract Five")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://localhost:44313/AgreeContract5?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            if (contract == "Contract Six")
            {
                strBody = strBody + "<tr>";
                strBody = strBody + "<td>https://localhost:44313/AgreeContract6?cid=" + max + "</td>";
                strBody = strBody + "</tr>";
            }
            strBody = strBody + "</tbody>";
            strBody = strBody + " </table>";

            Body = strBody;

            string sendEmail = gen.DoSendEmail(userEmail, userCC, userBCC, strSubject, Body);

        }

        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from tblcontract where companyid = '" + ddlCompany.SelectedItem.Value + "'";
            DataSet ds = gen.Get_Recordset(str, "mst_group");

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtContactName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtAmount.Text = ds.Tables[0].Rows[0][3].ToString();
                txtemail.Text = ds.Tables[0].Rows[0][2].ToString();

                string strDetails = "select * from tblcontractdetails where contractid = '" + ds.Tables[0].Rows[0][0].ToString() + "'";
                DataSet dsDetails = gen.Get_Recordset(strDetails, "mst_group");

                if (dsDetails.Tables[0].Rows.Count != 0)
                {
                    for (int i = 0; i < dsDetails.Tables[0].Rows.Count; i++)
                    {
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Contract one")
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
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Contract Two")
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
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Contract Three")
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
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Contract Four")
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
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Contract Five")
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
                        if (dsDetails.Tables[0].Rows[i][2].ToString() == "Contract Six")
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
                    }
                }
            }
        }

        protected void btnSendVideoLink_Click(object sender, EventArgs e)
        {
            string str = "select * from tblcontract where companyid = '" + ddlCompany.SelectedItem.Value + "'";
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
                strBody = strBody + "<td>https://localhost:44313/DocumnetUpload?cid=" + ds.Tables[0].Rows[0][0].ToString() + "</td>";
                strBody = strBody + "</tr>";

                strBody = strBody + "</tbody>";
                strBody = strBody + " </table>";

                Body = strBody;

                string sendEmail = gen.DoSendEmail(userEmail, userCC, userBCC, strSubject, Body);

            }

        }
    }
}