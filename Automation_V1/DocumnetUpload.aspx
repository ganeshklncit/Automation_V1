<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocumnetUpload.aspx.cs" Inherits="Automation_V1.DocumentUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <h1>Upload Document</h1>
    </div>

    <hr />

    <div class="row">
        <div class="col-md-12">
            <p>Please read the procedure to upload the document </p>

       </div>
    </div>

    <div class="row">

        <div class="col-md-3">
            <label asp-for="ddlDocType" class="col-form-label">Select Type of Document</label>
        </div>
        <div class="col-md-3">
            <asp:DropDownList ID="ddlDocType" runat="server" class="form-control" AutoPostBack="true">
                <asp:ListItem Text="Passport" Value="0" />
                <asp:ListItem Text="Driving License" Value="1" />
                <asp:ListItem Text="Other Document" Value="2" />
            </asp:DropDownList>
        </div>

        <div class="col-md-12">
            <asp:HiddenField ID="txtContractnumber" runat="server" />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="btnUpload" runat="server" Text="Upload Document" OnClick="Upload" CssClass="btn custom-btn" />
        </div>

        <br />

            <div class="col-md-12">
        <asp:GridView ID="GridView1" runat="server"
            AutoGenerateColumns="false" CssClass="table table-bordered table-hover table-responsive" HeaderStyle-BackColor="#c15c2d" HeaderStyle-BorderColor="#C15C2D" HeaderStyle-ForeColor="White">
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


         <div class="col-md-6">
         <asp:Button ID="btnAgree" runat="server" Text="Click to upload Video" CssClass="btn custom-btn" Enabled="false"  OnClick="btnAgree_Click"  />
         </div>

         <div class="col-md-6">

             <asp:HyperLink ID="HyperLink1" runat="server" target="_blank" NavigateUrl="~/VideoStatement.aspx" Visible="false">Click here to video statement</asp:HyperLink>

         
<%--             <button class="btn custom-btn" data-target="#loginmodal" data-toggle="modal">Click here to video statement</button>--%>

             

     <%--  <asp:Button ID="btnSampleVideo" runat="server" Text="Click here to video" id="basicAlert" CssClass="btn custom-btn"  Enabled="false" OnClick="btnSampleVideo_Click"  />--%>
       </div>

        <br />

          <div class="col-md-12">
          <asp:FileUpload ID="FileUpload2" runat="server" visible="false" />
          <asp:Button ID="btnUploadVideo" runat="server" Text="Upload Video" OnClick="Upload1" CssClass="btn custom-btn" visible="false" />
          </div>

    <br />

        <div class="col-md-12">
        <asp:Button ID="btnSubmit" runat="server" Text="Submit the Document" CssClass="btn custom-btn" visible="false" OnClick="btnSubmit_Click" />
        </div>

    </div>


   
        <script src="lib/sweetalert2/sweetalert2.all.min.js"></script>
        <link href="lib/sweetalert2/sweetalert2.css" rel="stylesheet" />
 
    <script>
        document.getElementById('basicAlert').addEventListener('click', function () {
            Swal.fire(
               ' Hello, my name is[Your Full Name].I am[your age / role, if relevant], and I am here to provide my identification details as requested.\r\n\r\nIdentification Information: \r\n\r\n    Full Name: [Your Full Name]\r\n    Date of Birth: [Your Date of Birth]\r\n    Identification Type: [Type of ID - e.g., Passport, National ID, Driver’s License]\r\n    ID Number: [Your ID Number]\r\n    Issued By: [Authority that issued the ID]\r\n    Issue Date: [Issue Date of the ID]\r\n    Expiration Date: [Expiration Date of the ID]\r\n    Nationality: [Your Nationality](if applicable) '
            )

        });

    </script>

   
</asp:Content>
