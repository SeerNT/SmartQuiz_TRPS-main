﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartQuiz
{
    public partial class UserTestResults : Form
    {
        public UserTestResults()
        {
            InitializeComponent();
        }

        private void end_test_button_Click(object sender, EventArgs e)
        {
            Program.userTestResults.Hide();
            Program.userTestsMenu.Show();
        }
    }
}
