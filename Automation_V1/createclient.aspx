<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="createclient.aspx.cs" Inherits="Automation_V1.createclient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Create Company</h1>
<hr />
<div class="row">
    <div class="col-md-6">
             <div class="form-group">
                <label asp-for="txtcompanyname" class="control-label">Company Name</label>
                 <asp:TextBox ID="txtcompanyname" runat="server" class="form-control"></asp:TextBox>           
            </div>
            <br/>
 
         <asp:Button ID="btnSubmit" class="button" runat="server" Text="Login" 
                             Width="82px" OnClick="btnSubmit_Click" />

            </div>
    </div>

    <script>
    function alertupdate() {
        swal("Company Created Succesfully", '', "success",);
    }
    </script>

</asp:Content>
