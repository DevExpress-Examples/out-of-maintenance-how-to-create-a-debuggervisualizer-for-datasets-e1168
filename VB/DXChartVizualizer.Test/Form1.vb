Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Collections

Namespace DXChartVizualizer.Test
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Program Files\Developer Express .NET v8.2\Demos\Data\nwind.mdb'")
            Dim selectCommand As New OleDbCommand("SELECT * FROM Categories")
            Dim da As New OleDbDataAdapter(selectCommand)
            Dim ds As New DataSet()

            selectCommand.Connection = connection
            da.Fill(ds, "Categories")

            selectCommand.CommandText = "SELECT TOP 10 * FROM Products"
            da.Fill(ds, "Products")

            dataGridView1.DataSource = ds
            dataGridView1.DataMember = ds.Tables(0).TableName

            Dim ds2 As New DataSet()
            Dim dt As New DataTable("MyDataTable")

            dt.Columns.Add("MyRow", GetType(String))
            dt.Columns.Add("MyData", GetType(Double))

            dt.Rows.Add(New Object() { "A", 103 })
            dt.Rows.Add(New Object() { "B", 200 })

            ds2.Tables.Add(dt)

            ' You can inspect Visualizer for the different DataTables represented
            ' in the variables "ds", "ds2" above.
            System.Diagnostics.Debugger.Break()
        End Sub
    End Class
End Namespace