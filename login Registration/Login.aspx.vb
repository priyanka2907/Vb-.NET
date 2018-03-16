Imports System
Imports System.Data
Imports System.Data.OleDb



Public Class Login
    Inherits System.Web.UI.Page
    'inside form class first craete database connection 
    Dim mpath As String = Server.MapPath("student.mdb")

    Dim connectionstring As String = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + mpath.ToString


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    'write one function for login

    Sub loginAuth()
        'now write code check username and password from database

        Dim con As OleDbConnection = New OleDbConnection(connectionstring)
        Dim flag1, flag2 As Boolean
        Try


            Using con

                con.Open() 'we open connection here

                Dim cmd As OleDbCommand = New OleDbCommand

                Using cmd

                    With cmd

                        .Connection = con

                        .CommandType = CommandType.Text
                        .CommandText = "SELECT * FROM Login WHERE username =@username AND password=@password " 'write query here
                        'now add parameter values
                        .Parameters.AddWithValue("@username", username.Text)
                        .Parameters.AddWithValue("@password", passowrd.Text)

                    End With

                    Dim mdataRdr As OleDbDataReader = cmd.ExecuteReader

                    If mdataRdr.HasRows Then



                        mdataRdr.Read()
                        Session("id") = mdataRdr("Tblid")
                        Session("username") = mdataRdr("username")
                        Session("name") = mdataRdr("sname")


                        flag1 = True
                        flag2 = True

                    End If
                End Using

            End Using

            If flag1 = True Then


                Response.Redirect("welcomeuser.aspx")


            End If
        Catch ex As Exception
            'error message if any
            lblerror.Text = Err.Description
        Finally


            If Not (con Is Nothing) Then

                con.Close()
            End If


        End Try



    End Sub






    Protected Sub loginbttn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loginbttn.Click
        'here button onclick event

        ' inside button onclick event call login duntion 

        'first check textbox is empty or not

        If username.Text <> "" And passowrd.Text <> "" Then
            loginAuth()


        Else
            lblerror.Text = "Please Enter Username and Password"


        End If
    End Sub

    Protected Sub regbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles regbtn.Click
        Response.Redirect("register.aspx")

    End Sub
End Class