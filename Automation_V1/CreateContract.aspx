<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateContract.aspx.cs" Inherits="Automation_V1.CreateContract" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <div class="form-group">
        <label asp-for="ddlCompany" class="control-label">Select Company</label>
        <asp:DropDownList ID="ddlCompany" runat="server" class="form-control"></asp:DropDownList>   
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
         
         <asp:CheckBox ID="chkcontract1" runat="server" Text="Contract one" />
         <br />
         <asp:CheckBox ID="chkcontract2" runat="server" Text="Contract Two" />
         <br />
         <asp:CheckBox ID="chkcontract3" runat="server" Text="Contract Three" />
         <br />
         <asp:CheckBox ID="chkcontract4" runat="server" Text="Contract Four" />
         <br />
         <asp:CheckBox ID="chkcontract5" runat="server" Text="Contract Five" />
         <br />
         <asp:CheckBox ID="chkcontract6" runat="server" Text="Contract Six" />        
     
     </div>

      <div class="form-group">
       <label asp-for="txtAmount" class="control-label">Monthly Amount</label>
      <asp:TextBox ID="txtAmount" runat="server" class="form-control"></asp:TextBox>     
       </div>

     <asp:Button ID="btnSubmit" class="button" runat="server" Text="Create Contract" Width="237px" OnClick="btnSubmit_Click" />

</asp:Content>
