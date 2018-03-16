<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="welcomeuser.aspx.vb" Inherits="VB.Net_Application.welcomeuser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>welcome</title>
    <!-- add css file here-->
 <link href="css/bootstrap.css"  rel="stylesheet" />
      <link href="css/bootstrap.min.css"  rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
 <p></p>


    <table class="table table-bordered">

<tr>
<td>Username : <b><asp:Label ID="lbluser" runat="server" Text=""></asp:Label> </td>

<td>Name :<b> <asp:Label ID="lblblname" runat="server" Text=""></asp:Label></td>

<td>Last Login Time : 
  <b>  <asp:Label ID="lbltime" runat="server" Text=""></asp:Label></td>

<td>
    <asp:Button ID="btnlogout" class="btn btn-danger" runat="server" Text="LogOut" /> </td>
<tr>

    </table>
          <asp:Label id ="lblerror" runat="server" Text="Label"></asp:Label>
   
   <hr>
   <h3>Student Information</h3>
   <hr>

        <asp:GridView ID="grdData" runat="server" Visible="false" AutoGenerateColumns="false" 
                 AlternatingRowStyle-BackColor="" Class="table table-bordered">
                <Columns >
                    <asp:TemplateField HeaderText="Sr. No" >
                        <ItemTemplate>
                            <asp:Label ID="lblSrNo" text="<%# Container.DataItemIndex + 1%>" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText ="Name"  DataField="Tblname" />
                    <asp:BoundField HeaderText ="Email"  DataField="Tblemail" />
                    <asp:BoundField HeaderText ="Course"  DataField="Tblcourse" />
                    <asp:BoundField HeaderText ="Phone No"  DataField="TblMobile" />
                   
                     
                 
                </Columns>
            </asp:GridView>

    </div>
    </form>
</body>
</html>
