<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgreeContract5.aspx.cs" Inherits="Automation_V1.AgreeContract5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Create Company</h1>
<hr />
<div class="row">
    <div class="col-md-6">
             <div class="form-group">
               <p>Contract Sample Text </p>         
            </div>

             <asp:HiddenField ID="txtContractnumber" runat="server"/>

            <br/>

        <asp:CheckBox ID="chkContract" runat="server" />
 
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
