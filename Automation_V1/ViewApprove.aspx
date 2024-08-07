<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewApprove.aspx.cs" Inherits="Automation_V1.ViewApprove" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
<label asp-for="ddlCompany" class="control-label">Select Company</label>
<asp:DropDownList ID="ddlCompany" runat="server" class="form-control" OnSelectedIndexChanged="ddlCompany_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>   
</div>

        <div class="form-group">
<label asp-for="ddlContract" class="control-label">Select Company</label>
<asp:DropDownList ID="ddlContract" runat="server" class="form-control" OnSelectedIndexChanged="ddlContract_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>   
</div>

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

     <asp:Button ID="btnSubmit" class="button" runat="server" Text="Approve" 
                     Width="82px" OnClick="btnSubmit_Click"  />

</div>  

</asp:Content>
