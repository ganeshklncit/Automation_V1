<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="createclient.aspx.cs" Inherits="Automation_V1.createclient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="row">

    <h1>Create Company</h1>


         </div>

    <hr />



    <div class="row g-3 align-items-center">
  <div class="col-auto">
        <label asp-for="txtcompanyname" class="col-form-label">Enter Company Name</label>
  </div>
  <div class="col-auto">
       <asp:TextBox ID="txtcompanyname" runat="server" class="form-control"></asp:TextBox>    
  </div>
  <div class="col-auto">
        <asp:Button ID="btnSubmit" class="btn custom-btn" runat="server" Text="Login" 
                             Width="82px" OnClick="btnSubmit_Click" />
  </div>
</div>
 


    
    <hr />




       <asp:GridView ID="GridView1" runat="server"   
            AutoGenerateColumns="false" CssClass="table table-bordered table-hover table-responsive" HeaderStyle-BackColor="#c15c2d" HeaderStyle-BorderColor="#C15C2D" HeaderStyle-ForeColor="White"> 
            <Columns>  
                <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />  
                <asp:TemplateField ItemStyle-HorizontalAlign="Center">  
                    <ItemTemplate>  
                        <asp:LinkButton ID="lnkDownload" runat="server" Text="Edit"  
                            CommandArgument='<%# Eval("id") %>'></asp:LinkButton>  
                    </ItemTemplate>  
                </asp:TemplateField>  
            </Columns>  

        

        </asp:GridView>  




    <script>
    function alertupdate() {
        swal("Company Created Succesfully", '', "success",);
    }
    </script>

</asp:Content>
