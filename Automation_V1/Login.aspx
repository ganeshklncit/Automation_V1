<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Automation_V1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

    <form id="form1" runat="server">
           <asp:ScriptManager runat="server"></asp:ScriptManager>
  <div class="form-group">
    <label for="exampleInputEmail1">Email address</label>
      <asp:TextBox ID="txtUsername" class="form-control" runat="server" placeholder="Enter email"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Password</label>
       <asp:TextBox ID="txtPassword" class="form-control" runat="server"  placeholder="Password" 
                            TextMode="Password"></asp:TextBox>
  </div>
 
        <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="Login" 
                             Width="82px" OnClick="btnSubmit_Click" />


</form>

</html>
