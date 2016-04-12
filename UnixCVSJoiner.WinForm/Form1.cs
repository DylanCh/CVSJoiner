using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.StellmanGreene.CSVReader;

namespace UnixCSVJoiner.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV Files (*.csv)|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataTable table = CSVReader.ReadCSVFile(dialog.FileName, true);
                dataGridView1.DataSource = table;
            }

        }
    }
}
