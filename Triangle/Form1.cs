﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tehnika t = new Tehnika();
            t.ShowDialog();
            this.Close();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Riided t = new Riided();
            t.ShowDialog();
            this.Close();
        }
    }
}
