﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                label2.Text = "";
                MessageBox.Show("이름을 입력하세요", "경고");
            }
            else
            {
                label2.Text = textBox1.Text + "님! 안녕하세요";
            }
            
        }
    }
}