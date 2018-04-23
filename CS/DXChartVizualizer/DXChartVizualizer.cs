using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

[assembly:
    System.Diagnostics.DebuggerVisualizer(
    typeof(DXChartVizualizer.DXChartVizualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(System.Data.DataSet),
    Description = "DXChartVizualizer")]

namespace DXChartVizualizer
{
    /// <summary>
    /// A Visualizer for SomeType.  
    /// </summary>
    public class DXChartVizualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            System.Data.DataSet data = (System.Data.DataSet)objectProvider.GetObject();
            DXChartVizualizerForm displayForm = new DXChartVizualizerForm();

            try {
                displayForm.AcceptDataSet(data);
            }
            catch(Exception) {
                MessageBox.Show("Can't find column of the appropriate data type for the values.");
                return;
            }

            windowService.ShowDialog(displayForm);
        }
    }
}