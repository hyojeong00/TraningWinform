﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "abcd" && txtPassword.Text == "1234")
            {
                lblResult.Text = "로그인 성공!";
            }
            else
            {
                lblResult.Text = "로그인 실패!";
            }
        }
    }
}
