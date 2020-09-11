using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Chart Control";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["수학"].Points.Add(400);
            chart1.Series[1].Points.Add(450);
            chart1.Series[1].Points.Add(40);
            chart1.Series[0].Points.Add(530);
            chart1.Series[0].Points.Add(200);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
