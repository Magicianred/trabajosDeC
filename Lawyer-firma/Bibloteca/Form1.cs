﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

      

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }
    }
}
