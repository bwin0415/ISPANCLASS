﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class MyUserControlOne : UserControl
    {
        public MyUserControlOne()
        {
            InitializeComponent();
        }

        private void MyUserControlOne_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblTitle.Text = txtTextInput.Text;
        }
    }
}
