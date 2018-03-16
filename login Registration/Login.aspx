<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="VB.Net_Application.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page Demo</title>
    <!--we added css file now add css file link here -->
    <link href="css/bootstrap.css"  rel="stylesheet" />
      <link href="css/bootstrap.min.css"  rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!--Now add required fields here -->
    <!--we added textbox and label here -->
    <h3>Login Page Demo</h3>
    <hr>
        <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
    <hr>
    <div class="row">

    <div class="col-sm-2"></div>
      <div class="col-sm-2">
          <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></div>
        <div class="col-sm-2">
            <asp:TextBox ID="username" runat="server" class="form-control"></asp:TextBox></div>
          <div class="col-sm-2"></div>
    </div>


    <br>

     <div class="row">

    <div class="col-sm-2"></div>
      <div class="col-sm-2">
          <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></div>
        <div class="col-sm-2">
            <asp:TextBox ID="passowrd" type="password" class="form-control" runat="server"></asp:TextBox></div>
          <div class="col-sm-2"></div>
    </div>
<br>

 <div class="row">

    <div class="col-sm-4"></div>
      <div class="col-sm-3">
          <asp:Button ID="loginbttn" runat="server" Text="Login" class="btn btn-danger" />

           <asp:Button ID="regbtn" runat="server" Text="Register" class="btn btn-danger" />
          </div>
        <div class="col-sm-2">
           </div>
          <div class="col-sm-2"></div>
    </div>


    </div>
    </form>
</body>
</html>
