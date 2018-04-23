using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace DXChartVizualizer {
    public partial class DXChartVizualizerForm : Form {
        private DataSet data;
        private List<string> dataTables;
        private List<List<string>> columnNamesForArgument;
        private List<List<string>> columnNamesForValue;

        public DXChartVizualizerForm() {
            InitializeComponent();

            chartControl1.Series.Clear();
        }

        internal void AcceptDataSet(DataSet data) {
            dataTables = new List<string>();
            columnNamesForArgument = new List<List<string>>();
            columnNamesForValue = new List<List<string>>();

            this.data = data;

            // Collect DataTable's information 
            foreach(DataTable dt in data.Tables) {
                List<string> argList = new List<string>();
                List<string> valList = new List<string>();

                // Collect DataColumn's information 
                foreach(DataColumn dc in dt.Columns) {
                    argList.Add(dc.ColumnName);

                    if(IsNumericType(dc.DataType) || IsDateTimeType(dc.DataType))
                        valList.Add(dc.ColumnName);
                }

                dataTables.Add(dt.TableName);

                columnNamesForArgument.Add(argList);
                columnNamesForValue.Add(valList);
            }

            comboBox1.DataSource = dataTables;
            comboBox2.DataSource = columnNamesForArgument[0];
            comboBox3.DataSource = columnNamesForValue[0];

            UpdateView();

            this.Text += ": " + data.GetType().FullName;
        }

        private void UpdateView() {
            chartControl1.Series.Clear();

            string tableName = comboBox1.SelectedValue.ToString();
            string argumentName = comboBox2.SelectedValue.ToString();
            string valueName = comboBox3.SelectedValue.ToString();

            Series series = new Series("Series", ViewType.Bar);

            Type argType = data.Tables[tableName].Columns[argumentName].DataType;
            Type valType = data.Tables[tableName].Columns[valueName].DataType;

            // Cpecify ScaleTypes
            if(IsNumericType(argType))
                series.ArgumentScaleType = ScaleType.Numerical;
            else if(IsDateTimeType(argType))
                series.ArgumentScaleType = ScaleType.DateTime;
            else
                series.ArgumentScaleType = ScaleType.Qualitative;

            if(IsNumericType(valType))
                series.ValueScaleType = ScaleType.Numerical;
            else if(IsDateTimeType(valType))
                series.ValueScaleType = ScaleType.DateTime;
            else
                throw new ArgumentException("Unsupported value type: " + valType.FullName);

            // Bound series to data
            series.DataSource = data.Tables[tableName];
            series.ArgumentDataMember = argumentName;
            series.ValueDataMembers.AddRange(new string[] { valueName });

            chartControl1.Series.Add(series);

            // Adjust AxisX
            (chartControl1.Diagram as XYDiagram).AxisX.Label.Angle =
                (series.ArgumentScaleType == ScaleType.Qualitative ? 45 : 0);
        }

        private bool IsNumericType(Type type) {
            return (type == typeof(Int32) || type == typeof(Int16) || type == typeof(Decimal) ||
                type == typeof(Double) || type == typeof(Single) || type == typeof(UInt32) || type == typeof(UInt16));
        }

        private bool IsDateTimeType(Type type) {
            return (type == typeof(DateTime));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            comboBox2.DataSource = columnNamesForArgument[dataTables.IndexOf(comboBox1.SelectedValue.ToString())];
            comboBox3.DataSource = columnNamesForValue[dataTables.IndexOf(comboBox1.SelectedValue.ToString())];
            UpdateView();
        }

        private void comboBox2And3_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateView();
        }
    }
}