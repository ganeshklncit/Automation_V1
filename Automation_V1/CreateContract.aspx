<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateContract.aspx.cs" Inherits="Automation_V1.CreateContract" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <div class="container">

        <div class="form-group">
        <label asp-for="ddlCompany" class="control-label">Select Company</label>
        <asp:DropDownList ID="ddlCompany" runat="server" class="form-control" OnSelectedIndexChanged="ddlCompany_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>   
        </div>

       
     <div class="form-group">
        <label asp-for="txtContactName" class="control-label">Contact Person Name</label>
        <asp:TextBox ID="txtContactName" runat="server" class="form-control"></asp:TextBox>     
             </div>


                <div class="form-group">
       <label asp-for="txtemail" class="control-label">Contact Email</label>
<asp:TextBox ID="txtemail" runat="server" class="form-control"></asp:TextBox>     
            </div>


     <div class="form-group">
         
         <asp:CheckBox ID="chkcontract1" runat="server" Text="Contract one" /> <asp:Label ID="lbl1" runat="server" Text="Label" Visible="false"></asp:Label>
         <br />
         <asp:CheckBox ID="chkcontract2" runat="server" Text="Contract Two" /> <asp:Label ID="lbl2" runat="server" Text="Label" Visible="false"></asp:Label>
         <br />
         <asp:CheckBox ID="chkcontract3" runat="server" Text="Contract Three" /> <asp:Label ID="lbl3" runat="server" Text="Label" Visible="false"></asp:Label>
         <br />
         <asp:CheckBox ID="chkcontract4" runat="server" Text="Contract Four" /> <asp:Label ID="lbl4" runat="server" Text="Label" Visible="false"></asp:Label>
         <br />
         <asp:CheckBox ID="chkcontract5" runat="server" Text="Contract Five" /> <asp:Label ID="lbl5" runat="server" Text="Label" Visible="false"></asp:Label>
         <br />
         <asp:CheckBox ID="chkcontract6" runat="server" Text="Contract Six" /> <asp:Label ID="lbl6" runat="server" Text="Label" Visible="false"></asp:Label>
     
     </div>

      <div class="form-group">
       <label asp-for="txtAmount" class="control-label">Monthly Amount</label>
      <asp:TextBox ID="txtAmount" runat="server" class="form-control"></asp:TextBox>     
       </div>

     <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="Create Contract" Width="237px" OnClick="btnSubmit_Click" />

     <asp:Button ID="btnSendVideoLink" class="btn btn-primary" runat="server" Text="Send Video Validation Link" OnClick="btnSendVideoLink_Click" />

          </div>

</asp:Content>
