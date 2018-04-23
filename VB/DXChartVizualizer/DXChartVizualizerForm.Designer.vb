Namespace DXChartVizualizer
    Partial Public Class DXChartVizualizerForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim sideBySideBarSeriesLabel3 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.label1 = New System.Windows.Forms.Label()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.comboBox2 = New System.Windows.Forms.ComboBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.comboBox3 = New System.Windows.Forms.ComboBox()
            Me.label3 = New System.Windows.Forms.Label()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.Range.SideMarginsEnabled = True
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Range.SideMarginsEnabled = True
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Location = New System.Drawing.Point(12, 36)
            Me.chartControl1.Name = "chartControl1"
            series1.Name = "Series 1"
            sideBySideBarSeriesLabel1.LineVisible = True
            series1.Label = sideBySideBarSeriesLabel1
            series2.Name = "Series 2"
            sideBySideBarSeriesLabel2.LineVisible = True
            series2.Label = sideBySideBarSeriesLabel2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
            sideBySideBarSeriesLabel3.LineVisible = True
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel3
            Me.chartControl1.Size = New System.Drawing.Size(629, 231)
            Me.chartControl1.TabIndex = 0
            ' 
            ' label1
            ' 
            Me.label1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(12, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(60, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "DataTable:"
            ' 
            ' comboBox1
            ' 
            Me.comboBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Location = New System.Drawing.Point(82, 6)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(97, 21)
            Me.comboBox1.TabIndex = 2
            ' 
            ' comboBox2
            ' 
            Me.comboBox2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Location = New System.Drawing.Point(318, 6)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(97, 21)
            Me.comboBox2.TabIndex = 4
            ' 
            ' label2
            ' 
            Me.label2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(216, 9)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(92, 13)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Argument column:"
            ' 
            ' comboBox3
            ' 
            Me.comboBox3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.comboBox3.FormattingEnabled = True
            Me.comboBox3.Location = New System.Drawing.Point(543, 6)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(97, 21)
            Me.comboBox3.TabIndex = 6
            ' 
            ' label3
            ' 
            Me.label3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(455, 9)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(74, 13)
            Me.label3.TabIndex = 5
            Me.label3.Text = "Value column:"
            ' 
            ' DXChartVizualizerForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(653, 279)
            Me.Controls.Add(Me.comboBox3)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.comboBox2)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.comboBox1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.Name = "DXChartVizualizerForm"
            Me.Text = "DXChartVizualizerForm"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private label1 As System.Windows.Forms.Label
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private WithEvents comboBox3 As System.Windows.Forms.ComboBox
        Private label3 As System.Windows.Forms.Label
    End Class
End Namespace