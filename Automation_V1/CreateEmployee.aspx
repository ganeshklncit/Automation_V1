<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateEmployee.aspx.cs" Inherits="Automation_V1.CreateEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">

    <h1>Create Employee</h1>

</div>

<hr />

        <div class="row g-3 align-items-center">

        <div class="col-md-3">
            <label asp-for="ddlCompany" class="col-form-label">Select Company</label>
        </div>
        <div class="col-md-3">
            <asp:DropDownList ID="ddlCompany" runat="server" class="form-control" OnSelectedIndexChanged="ddlCompany_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
           
        </div>

        <div class="col-md-3">
        </div>


        <div class="col-md-3">
        </div>


        <div class="col-md-3">
            <label asp-for="txtContactName" class="col-form-label">Contact Person Name</label>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtContactName" runat="server" class="form-control"></asp:TextBox>
        </div>

        <div class="col-md-3">
            
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



                <br />
       
     <div class="col-auto">
    <asp:Button ID="btnSubmit" class="btn custom-btn" runat="server" Text="Create Employee" Width="237px" OnClick="btnSubmit_Click" />
     </div>


            </div>

    <hr />





</asp:Content>
