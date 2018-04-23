using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace DXChartVizualizer.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Program Files\Developer Express .NET v8.2\Demos\Data\nwind.mdb'");
            OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM Categories");
            OleDbDataAdapter da = new OleDbDataAdapter(selectCommand);
            DataSet ds = new DataSet();

            selectCommand.Connection = connection;
            da.Fill(ds, "Categories");

            selectCommand.CommandText = "SELECT TOP 10 * FROM Products";
            da.Fill(ds, "Products");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].TableName;

            DataSet ds2 = new DataSet();
            DataTable dt = new DataTable("MyDataTable");

            dt.Columns.Add("MyRow", typeof(string));
            dt.Columns.Add("MyData", typeof(double));

            dt.Rows.Add(new object[] { "A", 103 });
            dt.Rows.Add(new object[] { "B", 200 });

            ds2.Tables.Add(dt);

            // You can inspect Visualizer for the different DataTables represented
            // in the variables "ds", "ds2" above.
            System.Diagnostics.Debugger.Break();
        }
    }
}