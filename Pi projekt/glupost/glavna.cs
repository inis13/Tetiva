﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace glupost
{
    public partial class glavna : Form
    {
        public glavna()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new PI.Dokumenti().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PI.Roba().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Prva().Show();
            this.Hide();
        }
    }
}
