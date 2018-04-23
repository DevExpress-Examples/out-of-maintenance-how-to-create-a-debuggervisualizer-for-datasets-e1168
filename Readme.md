# How to create a DebuggerVisualizer for DataSets


<p>This example illustrates how to write a debugger visualizer for DataSets. ChartControl is used to analyze data structure in a DataSet. A solution consists of two projects: DXChartVizualizer and the DXChartVizualizer.Test. Debugger visualizer implemented in the first project. It's is a "Class Library". Also, you can test its behavior in the second project. The only limitation of the created visualizer is that you can't visualize DataTables whose DataColumns have the non-integer or non-datatime data type. It's caused by the fact that the Series.ValueScaleType can't be set to the ScaleType.Qualitative value.</p><p>For Visual Studio to use our debugger visualizer, you should drop the DXChartVizualizer.dll in <Visual Studio Install Dir>\Common7\Packages\Debugger\Visualizers. However, you can automate this action by adding a corresponding Post-build step in the "Build Events" tab of the DXChartVizualizer project (see the \DXChartVizualizer\screenshot.JPG).</p>

<br/>


