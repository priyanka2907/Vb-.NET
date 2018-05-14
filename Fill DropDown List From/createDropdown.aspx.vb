Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Web.UI.HtmlControls
Imports System.IO

' here we added library files


Public Class createDropdown
    Inherits System.Web.UI.Page
    'add database path here..
    Dim mpath As String = Server.MapPath("Database/student.mdb")
    'Provider=Microsoft.Jet.OLEDB.4.0;Data Source="C:\Users\DATA10\Documents\Visual Studio 2010\Projects\Learn Project\Learn Project\Demo\Database\student.mdb"
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mpath.ToString


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'here we call function at the time of page load
        GetCourse()
    End Sub


    'HERE We write funtion for get course 
    Sub GetCourse()
        'here we fetch all course information
        ' Response.Write("inside function")
        Dim oCon As OleDbConnection = New OleDbConnection
        Dim mSql As String
        Dim batch As String

        batch = "2016-2019"
        ' here query for fetch data
        mSql = "SELECT ID,course + ' ' + batch+ ' '+ subject as droptext  FROM course WHERE batch=@batch ORDER BY subject "
        Try

            Using oCon

                oCon.ConnectionString = connectionString
                oCon.Open()
                Dim oCommand As OleDbCommand = New OleDbCommand

                Using oCommand

                    With oCommand
                        .Connection = oCon
                        .CommandType = CommandType.Text
                        .CommandText = mSql
                        .Parameters.AddWithValue("@batch", batch)
                    End With
                    Dim mAdapter As OleDbDataAdapter = New OleDbDataAdapter(oCommand)

                    Dim mDataSet As DataSet = New DataSet
                    mAdapter.Fill(mDataSet) 'here we fill query data into dataset
                    oCommand.Connection.Close() 'close  command 
                    'colse connection
                    oCon.Close()

                    dropcourse.DataSource = mDataSet
                    dropcourse.DataValueField = "ID"
                    dropcourse.DataTextField = "droptext"
                    dropcourse.DataBind()

                End Using
            End Using

            'now add data on dropdown
            dropcourse.Items.Insert(0, New ListItem("Select Course", 0))

        Catch ex As Exception

        End Try


    End Sub


End Class