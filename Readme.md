<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128573341/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1168)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DXChartVizualizer.Test/Form1.cs) (VB: [Form1.vb](./VB/DXChartVizualizer.Test/Form1.vb))
* [Program.cs](./CS/DXChartVizualizer.Test/Program.cs) (VB: [Program.vb](./VB/DXChartVizualizer.Test/Program.vb))
* [DXChartVizualizer.cs](./CS/DXChartVizualizer/DXChartVizualizer.cs) (VB: [DXChartVizualizerForm.vb](./VB/DXChartVizualizer/DXChartVizualizerForm.vb))
* [DXChartVizualizerForm.cs](./CS/DXChartVizualizer/DXChartVizualizerForm.cs) (VB: [DXChartVizualizerForm.vb](./VB/DXChartVizualizer/DXChartVizualizerForm.vb))
<!-- default file list end -->
# How to create a DebuggerVisualizer for DataSets


<p>This example illustrates how to write a debugger visualizer for DataSets. ChartControl is used to analyze data structure in a DataSet. A solution consists of two projects: DXChartVizualizer and the DXChartVizualizer.Test. Debugger visualizer implemented in the first project. It's is a "Class Library". Also, you can test its behavior in the second project. The only limitation of the created visualizer is that you can't visualize DataTables whose DataColumns have the non-integer or non-datatime data type. It's caused by the fact that the Series.ValueScaleType can't be set to the ScaleType.Qualitative value.</p><p>For Visual Studio to use our debugger visualizer, you should drop the DXChartVizualizer.dll in <Visual Studio Install Dir>\Common7\Packages\Debugger\Visualizers. However, you can automate this action by adding a corresponding Post-build step in the "Build Events" tab of the DXChartVizualizer project (see the \DXChartVizualizer\screenshot.JPG).</p>

<br/>


