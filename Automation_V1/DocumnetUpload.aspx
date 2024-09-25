<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocumnetUpload.aspx.cs" Inherits="Automation_V1.DocumentUpload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Upload Document</h1>
<hr />
<div class="row">
    <div class="col-md-6">
             <div class="form-group">
               <p>Contract Sample Text </p>         
            </div>
               <asp:HiddenField ID="txtContractnumber" runat="server"/>
            <br/>

      <asp:FileUpload ID="FileUpload1" runat="server" />  
        <asp:Button ID="btnUpload" runat="server" Text="Upload Driving License" OnClick="Upload" CssClass="btn-primary" />  
        <hr />  
        <asp:GridView ID="GridView1" runat="server"   
              
            AutoGenerateColumns="false" CssClass="table">  
            <Columns>  
                <asp:BoundField DataField="documenturl" HeaderText="File Name" />  
                <asp:TemplateField ItemStyle-HorizontalAlign="Center">  
                    <ItemTemplate>  
                        <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" OnClick="DownloadFile"  
                            CommandArgument='<%# Eval("contractdocumentid") %>'></asp:LinkButton>  
                    </ItemTemplate>  
                </asp:TemplateField>  
            </Columns>  
        </asp:GridView>  
    </div>  


     <asp:FileUpload ID="FileUpload2" runat="server" />  
   <asp:Button ID="Button1" runat="server" Text="Upload Passport" OnClick="Upload" CssClass="btn-primary" Width="200px" />  


      <asp:FileUpload ID="FileUpload4" runat="server" />  
    <asp:Button ID="Button3" runat="server" Text="Upload Other Documents" OnClick="Upload" CssClass="btn-primary" Width="200px"  />  

     <asp:FileUpload ID="FileUpload3" runat="server" />  
   <asp:Button ID="Button2" runat="server" Text="Upload Video" OnClick="Upload" CssClass="btn-primary" Width="200px"  />  



    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn-primary" OnClick="btnSubmit_Click" />  

    </div>
 

    <script>
    function alertupdate() {
        swal("Company Created Succesfully", '', "success",);
    }
    </script>

</asp:Content>
