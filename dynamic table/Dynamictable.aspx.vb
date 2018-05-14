Imports System
Imports System.Data
Imports System.IO


Public Class Dynamictable
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'assign value to div

        tbl.InnerHtml += "<table class='table table-bordered'>"
        'add table header
        For i = 1 To 5


            tbl.InnerHtml += "<thaed><th>Test " & i & "</th> </thead>"

        Next

        'start new row
        tbl.InnerHtml += "<tr>"
        'add row data
        For j = 1 To 10 'for rowcount

            For k = 1 To 5 'for row data
                tbl.InnerHtml += "<td> <input type='text' class='form-control' name='text" & j & "' class='txt'></td>"
            Next
            tbl.InnerHtml += "</tr>"
        Next
        tbl.InnerHtml += "</table>"
    End Sub

End Class