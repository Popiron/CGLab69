﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CGLab69.Lab7
{
    public partial class Lab7Form : Form
    {
        public Lab7Form()
        {
            InitializeComponent();
        }

        private void artemButton_Click(object sender, EventArgs e)
        {
            ArtemForm form = new ArtemForm();
            form.ShowDialog();
        }

        private void dimaButton_Click(object sender, EventArgs e)
        {
            DimaForm form = new DimaForm();
            form.ShowDialog();
        }

        private void amirButton_Click(object sender, EventArgs e)
        {
            AmirForm form = new AmirForm();
            form.ShowDialog();
        }
    }
}
