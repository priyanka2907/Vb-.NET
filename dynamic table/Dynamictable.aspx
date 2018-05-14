<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Dynamictable.aspx.vb" Inherits="Learn_Project.Dynamictable" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Dynamic table</title>

    <link href="../css/custom.css" rel="stylesheet" />
    <link href="../css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <h3>Dynamic Table Example</h3>

    <div class="row">

    
    <div class="col-sm-3"> </div>
      <div class="col-sm-6"> 
    <div id="tbl" runat="server">
    



    </div ></div>
      <div class="col-sm-3"> </div>
    </div>
    </div>
    </form>
</body>
</html>
