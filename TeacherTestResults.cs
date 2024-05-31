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
    public partial class TeacherTestResults : Form
    {
        public TeacherTestResults()
        {
            InitializeComponent();
        }

        private void new_test_label_Click(object sender, EventArgs e)
        {

        }

        private void showFeedbackButton_Click(object sender, EventArgs e)
        {
            Program.teacherTestResults.Hide();
            Program.feedbackTeacher.Show();
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            Program.teacherTestResults.Hide(); 
            Program.teacherMenu.Show();
        }
    }
}
