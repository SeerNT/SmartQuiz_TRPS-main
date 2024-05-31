using System;
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
    public partial class TeacherMenu : Form
    {
        public TeacherMenu()
        {
            InitializeComponent();
        }

        private void editTestButton_Click(object sender, EventArgs e)
        {
            Program.teacherMenu.Hide();
            Program.teacherNewTestForm.Show();
        }

        private void showResultsButton_Click(object sender, EventArgs e)
        {
            Program.teacherMenu.Hide();
            Program.teacherTestResults.Show();
        }
    }
}
