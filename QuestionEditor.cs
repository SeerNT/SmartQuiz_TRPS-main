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
    public partial class QuestionEditor : Form
    {
        public QuestionEditor()
        {
            InitializeComponent();
        }

        private void accept_question_button_Click(object sender, EventArgs e)
        {
            Program.questionEditor.Hide(); 
            Program.questionsDesignerForm.Show();
        }
    }
}
