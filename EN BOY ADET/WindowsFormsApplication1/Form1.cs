﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int en = int.Parse (textBox1.Text);
            int boy = int.Parse (textBox2.Text);
            int adet = int.Parse (textBox3.Text);
            int sonuc;

            sonuc = (en * boy)-adet ;
            MessageBox.Show(sonuc.ToString());

        }
    }
}
