<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="register.aspx.vb" Inherits="VB.Net_Application.register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New User Registration</title>

      <!--we added css file now add css file link here -->
    <link href="css/bootstrap.css"  rel="stylesheet" />
      <link href="css/bootstrap.min.css"  rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div><hr>
  <h3>  <p> Register New User</p></h3><hr>

   <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
  <div class="row">
     
  <div class="col-sm-2">
  </div>

  <div class="col-sm-2">
      <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
  </div>

  <div class="col-sm-3">
      <asp:TextBox ID="username" class="form-control" runat="server"></asp:TextBox>
  </div>

  <div class="col-sm-2">
  </div>
  
  </div>
  <br>

  
  <div class="row">
  <div class="col-sm-2">
  </div>

  <div class="col-sm-2">
      <asp:Label ID="Label2" runat="server" Text="Passowrd"></asp:Label>
  </div>

  <div class="col-sm-3">
      <asp:TextBox ID="password" type="password" class="form-control" runat="server"></asp:TextBox>
  </div>

  <div class="col-sm-2">
  </div>
  
  </div>
  <br>




  <div class="row">
  <div class="col-sm-2">
  </div>

  <div class="col-sm-2">
      <asp:Label ID="Label3" runat="server" Text="name"></asp:Label>
  </div>

  <div class="col-sm-3">
      <asp:TextBox ID="name" class="form-control" runat="server"></asp:TextBox>
  </div>

  <div class="col-sm-2">
  </div>
  
  </div>
  <br>

  
  <div class="row">
  <div class="col-sm-4">
  </div>

  <div class="col-sm-3">
     <asp:Button ID="regbtn" class="btn btn-danger" runat="server" Text="Register" />
     <asp:Button ID="lgnbtn" class="btn btn-danger" runat="server" Text="Login" />
  </div>
      

  <div class="col-sm-3">
    
  </div>

  <div class="col-sm-2">
  </div>
  
  </div>
  <br>


    </div>
    </form>
</body>
</html>
