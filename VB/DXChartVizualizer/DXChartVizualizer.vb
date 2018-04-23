Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Microsoft.VisualStudio.DebuggerVisualizers

<Assembly: System.Diagnostics.DebuggerVisualizer(GetType(DXChartVizualizer.DXChartVizualizer), GetType(VisualizerObjectSource), Target := GetType(System.Data.DataSet), Description := "DXChartVizualizer")>

Namespace DXChartVizualizer
    ''' <summary>
    ''' A Visualizer for SomeType.  
    ''' </summary>
    Public Class DXChartVizualizer
        Inherits DialogDebuggerVisualizer

        Protected Overrides Sub Show(ByVal windowService As IDialogVisualizerService, ByVal objectProvider As IVisualizerObjectProvider)
            Dim data As System.Data.DataSet = DirectCast(objectProvider.GetObject(), System.Data.DataSet)
            Dim displayForm As New DXChartVizualizerForm()

            Try
                displayForm.AcceptDataSet(data)
            Catch e1 As Exception
                MessageBox.Show("Can't find column of the appropriate data type for the values.")
                Return
            End Try

            windowService.ShowDialog(displayForm)
        End Sub
    End Class
End Namespace