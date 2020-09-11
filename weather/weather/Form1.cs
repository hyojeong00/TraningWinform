﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace weather
{
    public partial class Form1 : Form
    {
        List<string> Temp = new List<string>();
        List<string> Hour = new List<string>();
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(220, 240, 230);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XElement axElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2623052000");
            var XMLData = from Temp in axElement.Descendants("data")
                          select new weather()
                          {
                              hour = Temp.Element("hour").Value,
                              temp = Temp.Element("temp").Value,
                              wfKor = Temp.Element("wfKor").Value,
                              wdKor = Temp.Element("wdKor").Value
                          };

            foreach (var item in XMLData)
            {
                Console.WriteLine(item);

                Temp.Add(item.temp);
            }

            chart1.Series[0].Points.DataBindY(Temp);
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].IsValueShownAsLabel = true;

            chart1.Series[1].Points.DataBindY(Hour);
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].IsValueShownAsLabel = true;
        }
    }
}
