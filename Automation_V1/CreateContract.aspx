<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateContract.aspx.cs" Inherits="Automation_V1.CreateContract" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>

        .check-space{
  margin-right: 15px;
}

    </style>

    <div class="row">

        <h1>Create Contract</h1>

    </div>

    <hr />

    <div class="row g-3 align-items-center">

        <div class="col-md-3">
            <label asp-for="ddlCompany" class="col-form-label">Select Company</label>
        </div>
        <div class="col-md-3">
            <asp:DropDownList ID="ddlCompany" runat="server" OnSelectedIndexChanged="ddlCompany_SelectedIndexChanged" class="form-select mb-3" AutoPostBack="true"></asp:DropDownList>
           
        </div>

        <div class="col-md-3">
        </div>


        <div class="col-md-3">
        </div>


        <div class="col-md-3">
            <label asp-for="txtContactName" class="col-form-label">Contact Person Name</label>
        </div>
        <div class="col-md-3">
            <asp:DropDownList ID="txtContactName" runat="server" OnSelectedIndexChanged="txtContactName_SelectedIndexChanged" class="form-select mb-3" AutoPostBack="true"></asp:DropDownList>
        </div>

        <div class="col-md-3">
              <asp:Button ID="btnEmployee" class="btn custom-btn" runat="server" Text="Create New Employee Name" Width="237px" OnClick="btnEmployee_Click"/>
        </div>


        <div class="col-md-3">
        </div>

        <div class="col-md-3">
            <label asp-for="txtemail" class="col-form-label">Contact Email</label>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtemail" runat="server" class="form-control"></asp:TextBox>

        </div>


        <div class="col-md-3">
        </div>


        <div class="col-md-3">
        </div>


        
        <div class="col-md-3">
             <label asp-for="txtAmount" class="col-form-label">Monthly Amount GBP (+VAT)</label>
        </div>


        <div class="col-md-3">
            <asp:TextBox ID="txtAmount" runat="server" class="form-control"></asp:TextBox>
        </div>


        
        <div class="col-md-3">
        </div>


        <div class="col-md-3">
        </div>

        <div class="form-group">

            <div class="col-md-12 gap-3">
                <asp:CheckBox ID="chkcontract1" runat="server" Text="CIC accounts" /> &nbsp; 
                <asp:Label ID="lbl1" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
            </div>

             <div class="col-md-12 gap-3">
            <asp:CheckBox ID="chkcontract2" runat="server" Text="Corporation Tax" />  &nbsp; 
            <asp:Label ID="lbl2" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
             </div>

             <div class="col-md-12 gap-3">
            <asp:CheckBox ID="chkcontract3" runat="server" Text="General Terms and Conditions All Clients" />  &nbsp; 
            <asp:Label ID="lbl3" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
                 </div>

             <div class="col-md-12 gap-3">
            <asp:CheckBox ID="chkcontract4" runat="server" Text="LLP Accounts" />
            <asp:Label ID="lbl4" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
                 </div>

             <div class="col-md-12 gap-3">
            <asp:CheckBox ID="chkcontract5" runat="server" Text="Partnership accounts preperation" />
            <asp:Label ID="lbl5" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
                 </div>

             <div class="col-md-12 gap-3">
            <asp:CheckBox ID="chkcontract6" runat="server" Text="Payroll Services" />
            <asp:Label ID="lbl6" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
        </div>

                 <div class="col-md-12 gap-3">
    <asp:CheckBox ID="chkcontract7" runat="server" Text="SCIO Charity accounts" />
    <asp:Label ID="lbl7" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
</div>

                 <div class="col-md-12 gap-3">
    <asp:CheckBox ID="chkcontract8" runat="server" Text="Sole Trader accounts Preperation" />
    <asp:Label ID="lbl8" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
</div>


           <div class="col-md-12 gap-3">
    <asp:CheckBox ID="chkcontract9" runat="server" Text="Unicorporated Charity accounts receipts Payments" />
    <asp:Label ID="lbl9" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
</div>


                 <div class="col-md-12 gap-3">
    <asp:CheckBox ID="chkcontract10" runat="server" Text="Unicorporated Charity accounts accruals" />
    <asp:Label ID="lbl10" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>



                          <div class="col-md-12 gap-3">
    <asp:CheckBox ID="chkcontract11" runat="server" Text="unregistred club accounts" />
    <asp:Label ID="lbl11" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
</div>



                          <div class="col-md-12 gap-3">
    <asp:CheckBox ID="chkcontract12" runat="server" Text="VAT" />
    <asp:Label ID="lbl12" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
</div>


                                               <div class="col-md-12 gap-3">
    <asp:CheckBox ID="chkcontract13" runat="server" Text="Limited Company Charity accouts" />
    <asp:Label ID="lbl13" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>
</div>


                                               <div class="col-md-12 gap-3">
    <asp:CheckBox ID="chkcontract14" runat="server" Text="Limited Company Statuory accounts preperation" />
    <asp:Label ID="lbl14" runat="server" Text="Label" Visible="false" Font-Bold="True"></asp:Label>


</div>


</div>

            <br />
       
             <div class="col-auto">
            <asp:Button ID="btnSubmit" class="btn custom-btn" runat="server" Text="Create Contract" Width="237px" OnClick="btnSubmit_Click" />

      
            <asp:Button ID="btnSendVideoLink" class="btn custom-btn" runat="server" Text="Send Video Validation Link" OnClick="btnSendVideoLink_Click" />

        </div>


    </div>



</asp:Content>
