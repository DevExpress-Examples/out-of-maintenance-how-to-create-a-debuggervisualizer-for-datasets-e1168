Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace DXChartVizualizer
    Partial Public Class DXChartVizualizerForm
        Inherits Form

        Private data As DataSet
        Private dataTables As List(Of String)
        Private columnNamesForArgument As List(Of List(Of String))
        Private columnNamesForValue As List(Of List(Of String))

        Public Sub New()
            InitializeComponent()

            chartControl1.Series.Clear()
        End Sub

        Friend Sub AcceptDataSet(ByVal data As DataSet)
            dataTables = New List(Of String)()
            columnNamesForArgument = New List(Of List(Of String))()
            columnNamesForValue = New List(Of List(Of String))()

            Me.data = data

            ' Collect DataTable's information 
            For Each dt As DataTable In data.Tables
                Dim argList As New List(Of String)()
                Dim valList As New List(Of String)()

                ' Collect DataColumn's information 
                For Each dc As DataColumn In dt.Columns
                    argList.Add(dc.ColumnName)

                    If IsNumericType(dc.DataType) OrElse IsDateTimeType(dc.DataType) Then
                        valList.Add(dc.ColumnName)
                    End If
                Next dc

                dataTables.Add(dt.TableName)

                columnNamesForArgument.Add(argList)
                columnNamesForValue.Add(valList)
            Next dt

            comboBox1.DataSource = dataTables
            comboBox2.DataSource = columnNamesForArgument(0)
            comboBox3.DataSource = columnNamesForValue(0)

            UpdateView()

            Me.Text &= ": " & data.GetType().FullName
        End Sub

        Private Sub UpdateView()
            chartControl1.Series.Clear()

            Dim tableName As String = comboBox1.SelectedValue.ToString()
            Dim argumentName As String = comboBox2.SelectedValue.ToString()
            Dim valueName As String = comboBox3.SelectedValue.ToString()

            Dim series As New Series("Series", ViewType.Bar)

            Dim argType As Type = data.Tables(tableName).Columns(argumentName).DataType
            Dim valType As Type = data.Tables(tableName).Columns(valueName).DataType

            ' Cpecify ScaleTypes
            If IsNumericType(argType) Then
                series.ArgumentScaleType = ScaleType.Numerical
            ElseIf IsDateTimeType(argType) Then
                series.ArgumentScaleType = ScaleType.DateTime
            Else
                series.ArgumentScaleType = ScaleType.Qualitative
            End If

            If IsNumericType(valType) Then
                series.ValueScaleType = ScaleType.Numerical
            ElseIf IsDateTimeType(valType) Then
                series.ValueScaleType = ScaleType.DateTime
            Else
                Throw New ArgumentException("Unsupported value type: " & valType.FullName)
            End If

            ' Bound series to data
            series.DataSource = data.Tables(tableName)
            series.ArgumentDataMember = argumentName
            series.ValueDataMembers.AddRange(New String() { valueName })

            chartControl1.Series.Add(series)

            ' Adjust AxisX
            TryCast(chartControl1.Diagram, XYDiagram).AxisX.Label.Angle = (If(series.ArgumentScaleType = ScaleType.Qualitative, 45, 0))
        End Sub

        Private Function IsNumericType(ByVal type As Type) As Boolean
            Return (type Is GetType(Int32) OrElse type Is GetType(Int16) OrElse type Is GetType(Decimal) OrElse type Is GetType(Double) OrElse type Is GetType(Single) OrElse type Is GetType(UInt32) OrElse type Is GetType(UInt16))
        End Function

        Private Function IsDateTimeType(ByVal type As Type) As Boolean
            Return (type Is GetType(Date))
        End Function

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            comboBox2.DataSource = columnNamesForArgument(dataTables.IndexOf(comboBox1.SelectedValue.ToString()))
            comboBox3.DataSource = columnNamesForValue(dataTables.IndexOf(comboBox1.SelectedValue.ToString()))
            UpdateView()
        End Sub

        Private Sub comboBox2And3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged, comboBox3.SelectedIndexChanged
            UpdateView()
        End Sub
    End Class
End Namespace