<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="createDropdown.aspx.vb" Inherits="Learn_Project.createDropdown" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dropdown Exmaple</title>

    <link href ="../css/style.css" rel="stylesheet" />
     <link href ="../css/bootstrap.css" rel="stylesheet" />
</head>
<body>


    <form id="form1" runat="server">
    <div>
  <h3>  <p>Dropdown data fetch from Database!</p>
 </h3>
 <div class="row">

 <div class="col-sm-2"></div>
 <div class="col-sm-2">
     <asp:Label ID="lblprogram" runat="server" Text="Program Name:"></asp:Label></div>
 <div class="col-sm-6">
     <asp:DropDownList ID="dropcourse" class="form-control" runat="server">
     </asp:DropDownList>
 </div>
 </div>
    </div>
    </form>
</body>
</html>
