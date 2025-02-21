<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewApprove.aspx.cs" Inherits="Automation_V1.ViewApprove" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <h1>View and approve Document</h1>
    </div>

    <hr />

     <div class="row g-3 align-items-center">

         <div class="col-md-3">
               <label asp-for="ddlCompany" class="control-label">Select Company</label>
             </div>
         <div class="col-md-3">
  <asp:DropDownList ID="ddlCompany" runat="server" class="form-control" OnSelectedIndexChanged="ddlCompany_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
             </div>

    <div class="col-md-3">
        </div>

         <div class="col-md-3">
             </div>

     <div class="col-md-3">
      <label asp-for="ddlContract" class="control-label">Select Contract</label>
         </div>

          <div class="col-md-3">
     <asp:DropDownList ID="ddlContract" runat="server" class="form-control" OnSelectedIndexChanged="ddlContract_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
              </div>

              </div>

     <br />

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
 
     <div class="col-md-12">
    <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
  </div>

    <asp:Button ID="btnSubmit" class="btn custom-btn" runat="server" Text="Approve"
        Width="82px" OnClick="btnSubmit_Click" />

 
</asp:Content>
