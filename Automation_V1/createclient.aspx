<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="createclient.aspx.cs" Inherits="Automation_V1.createclient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Create Client</h1>
<hr />
<div class="row">
    <div class="col-md-6">
             <div class="form-group">
                <label asp-for="txtcompanyname" class="control-label">Company Name</label>
                 <asp:TextBox ID="txtcompanyname" runat="server" class="form-control"></asp:TextBox>           
            </div>
            <br/>
          
         <div class="form-group">
        <label asp-for="txtclientname" class="control-label">Contact Person Name</label>
 <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>     
             </div>


                <div class="form-group">
       <label asp-for="txtemail" class="control-label">Contact Email</label>
<asp:TextBox ID="txtemail" runat="server" class="form-control"></asp:TextBox>     
            </div>




            </div>
    </div>

</asp:Content>
