<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgreeContract1.aspx.cs" Inherits="Automation_V1.AgreeContract1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>CIC Accounts</h1>
<hr />
<div class="row">
    <div class="col-md-6">
             <div class="form-group">
               <p>Letter of engagement - non-audit accounts assignment for a community interest company</p>      

                   <p>The Directors of Company </p>      
                 
                  <p>Date</p>

                 <p> We are pleased to accept the instruction to act as accountant for your company and are writing the terms of our appointment. </p>

                   <p> The purpose of this letter, together with the attached terms and conditions, is to set out our terms for carrying out the work and to clarify out respective responsibilities </p>



            </div>

             <asp:HiddenField ID="txtContractnumber" runat="server"/>

            <br/>

        <asp:CheckBox ID="chkContract" runat="server" />
 
         <asp:Button ID="btnSubmit" class="button" runat="server" Text="Accept" 
                             Width="82px" OnClick="btnSubmit_Click" />

            </div>
    </div>

    <script>
    function alertupdate() {
        swal("Company Created Succesfully", '', "success",);
    }
    </script>

</asp:Content>
