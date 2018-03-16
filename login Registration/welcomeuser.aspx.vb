Imports System
Imports System.Data
Imports System.Data.OleDb


Public Class welcomeuser
    Inherits System.Web.UI.Page


    'inside form class first craete database connection 
    Dim mpath As String = Server.MapPath("student.mdb")

    Dim connectionstring As String = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + mpath.ToString
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'now add session variables
      

        lblblname.Text = Session("name")

        lbluser.Text = Session("username")
        lbltime.Text = Now()
        getData()

    End Sub

    Protected Sub btnlogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnlogout.Click


        clersession()


    End Sub


    Sub clersession()

        session("name") = ""
        session("username") = ""

        Response.Redirect("login.aspx?action=logout")


    End Sub



    Sub getData()


        Dim con As OleDbConnection = New OleDbConnection(connectionstring)
        Dim flah1 As Boolean
        Try



            Using con

                con.Open()


                Dim cmd As OleDbCommand = New OleDbCommand

                Using cmd





                    With cmd


                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = "select * from student" 'write query here




                    End With

                    Dim mDataRdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                    Dim ds As DataSet = New DataSet
                    Dim dt As DataTable = New DataTable

                    If mDataRdr.HasRows Then

                        flah1 = True
                        dt.Load(mDataRdr)
                        grdData.DataSource = dt
                        grdData.DataBind()
                        grdData.Visible = True
                    Else

                        lblerror.Text = "No Data Fount "

                    End If

                    mDataRdr.Close()


                End Using
            End Using

        Catch ex As Exception

        End Try

    End Sub


End Class