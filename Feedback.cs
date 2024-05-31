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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void sendFeedbackButton_Click(object sender, EventArgs e)
        {
            Program.feedbackTeacher.Hide();
            Program.teacherTestResults.Show();
        }
    }
}
