using SmartQuiz.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SmartQuiz
{
    public partial class UserTest : Form
    {
        int leftTime;
        List<TextBox> userAnswersBoxes = new List<TextBox>();
        List<string> userAnswers = new List<string>();

        public static int resultMark;

        public UserTest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void end_test_button_Click(object sender, EventArgs e)
        {
            foreach(TextBox box in userAnswersBoxes)
            {
                userAnswers.Add(box.Text);
            }
            int i = 0;

            foreach(Question q in Program.userTestsMenu.GetTest().questions)
            {
                
                if (q.answer == userAnswers[i])
                {
                    resultMark += 1;
                }
                i++;
            }

            Program.userTestForm.Hide();
            Program.userTestsMenu.Show();
            Program.userTestsMenu.UpdateText();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void UserTest_Load(object sender, EventArgs e)
        {
            testLabel.Text = Program.userTestsMenu.GetTest().name;
            int i = 0;
            foreach(Question question in Program.userTestsMenu.GetTest().questions)
            {
                Label qLab = new Label();
                qLab.Text = question.name;
                qLab.AutoSize = true;
                qLab.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                qLab.Location = new Point(6, 23);
                qLab.Name = "questionLabel";
                qLab.Size = new Size(197, 22);
                qLab.TabIndex = 1;
                Label qDesc = new Label();
                qDesc.AutoSize = true;
                qDesc.Font = new Font("Arial", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
                qDesc.Location = new Point(6, 58);
                qDesc.Name = "questionDesc";
                qDesc.Size = new Size(152, 19);
                qDesc.TabIndex = 2;
                qDesc.Text = question.description;
                TextBox userAnswerBox = new TextBox();
                userAnswerBox.BorderStyle = BorderStyle.FixedSingle;
                userAnswerBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                userAnswerBox.Location = new Point(6, 176);
                userAnswerBox.Name = "test_name_box";
                userAnswerBox.PlaceholderText = "Введите ответ";
                userAnswerBox.Size = new Size(274, 33);

                userAnswersBoxes.Add(userAnswerBox);

                PictureBox image = new PictureBox();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTest));
                image.Image = (Properties.Resources.graph1);
                image.Location = new Point(307, 13);
                image.Size = new Size(320, 229);
                image.Name = "pictureBox";
                image.TabIndex = 17;
                image.TabStop = false;

                Button nextQuestionBut = new Button();
                nextQuestionBut.BackColor = SystemColors.ControlText;
                nextQuestionBut.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
                nextQuestionBut.ForeColor = SystemColors.ControlLightLight;
                nextQuestionBut.Location = new Point(6, 228);
                nextQuestionBut.Size = new Size(274, 37);
                nextQuestionBut.TabIndex = 15;
                nextQuestionBut.Text = "Следующий вопрос";
                nextQuestionBut.UseVisualStyleBackColor = false;
                nextQuestionBut.Click += NextQuestion;

                tabControl1.TabPages.Add(new TabPage());
                tabControl1.TabPages[i].Text = (i+1).ToString();
                tabControl1.TabPages[i].Controls.Add(qLab);
                tabControl1.TabPages[i].Controls.Add(qDesc);
                tabControl1.TabPages[i].Controls.Add(userAnswerBox);
                tabControl1.TabPages[i].Controls.Add(nextQuestionBut);
                tabControl1.TabPages[i].Controls.Add(image);

                i++;
            }

            leftTime = Program.userTestsMenu.GetTest().secondsLength;

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
        }

        private void NextQuestion(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            leftTime--;
            TimeSpan result = TimeSpan.FromSeconds(leftTime);
            string fromTimeString = "Осталось: " + result.ToString("hh':'mm':'ss");
            timeLabel.Text = fromTimeString;
            if(leftTime <= 0)
            {
                timer1.Enabled = false;
                Program.userTestForm.Hide();
                Program.userTestsMenu.Show();
            }
        }
    }
}
