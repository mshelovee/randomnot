﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_not__96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbNotlar.Items.Clear();
            Random rnd = new Random();

            for (int i=0; i<=14; i++)
            {
                int puan = rnd.Next(0,100);

                lbNotlar.Items.Add(puan);
            }

        }
    }
}
