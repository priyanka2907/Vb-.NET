Imports System
Imports System.Data
Imports System.Data.OleDb


Public Class register
    Inherits System.Web.UI.Page

    'add database connectivity

    'inside form class first craete database connection 
    Dim mpath As String = Server.MapPath("student.mdb")

    Dim connectionstring As String = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + mpath.ToString


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub




    Sub registeract()

        'here craete connection and command variables

        Dim con As OleDbConnection = New OleDbConnection(connectionstring)
        Dim flag1, flag2 As Boolean

        Dim ipadd, time As String

        ipadd = Request.ServerVariables("REMOTE_ADDR")
        time = Now()


        Try


            Using con


                con.Open() 'here we open connection


                Dim cmd As OleDbCommand = New OleDbCommand

                Using cmd


                    With cmd




                        .Connection = con

                        .CommandType = CommandType.Text
                        ' here write insert query 
                        .CommandText = "INSERT INTO Login ([username],[password],[sname],[ipaddress],[tbldate])" & _
                        "Values(@username,@password,@sname,@ipaddress,@tbldate)"

                        .Parameters.AddWithValue("@username", username.Text)
                        .Parameters.AddWithValue("@password", password.Text)
                        .Parameters.AddWithValue("@sname", name.Text)
                        .Parameters.AddWithValue("@ipaddress", ipadd)
                        .Parameters.AddWithValue("@tbldate", time)



                    End With
                    Dim mrecord = cmd.ExecuteNonQuery
                    If mrecord = 1 Then
                        flag1 = True
                        lblerror.Text = "registration is successful"

                    End If

                End Using

                con.Close()



            End Using
        Catch ex As Exception
            lblerror.Text = Err.Description
        Finally


            If Not (con Is Nothing) Then

                con.Close()
            End If
        End Try



    End Sub

    Protected Sub regbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles regbtn.Click
        'on click register button call function

        registeract()

    End Sub

    Protected Sub lgnbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lgnbtn.Click
        'click on login button goto login page
        Response.Redirect("Login.aspx")
    End Sub
End Class