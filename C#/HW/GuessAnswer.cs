﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class GuessAnswer : Form
    {
        public GuessAnswer(int num)
        {
            InitializeComponent();
            LabAnswer.Text = "" + num;
        }
    }
}
