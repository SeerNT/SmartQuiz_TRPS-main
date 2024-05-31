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
    public partial class TestChoice : Form
    {
        Test test;

        public Test GetTest()
        {
            return test;
        }

        public TestChoice()
        {
            InitializeComponent();
        }

        private void startTest_Click(object sender, EventArgs e)
        {
            Program.userTestsMenu.Hide();
            Program.userTestForm.Show();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void UpdateText()
        {
            triesText.Hide();
            startTest.Hide();
            markLabel.Text = "Итоговая оценка: " + UserTest.resultMark.ToString();
        }

        private void TestChoice_Load(object sender, EventArgs e)
        {
            test = new Test();
            test.name = "Вычислительная Математика Первый Модуль";
            test.secondsLength = 1800;

            testName.Text = test.name;

            TimeSpan result = TimeSpan.FromSeconds(test.secondsLength);
            string fromTimeString = "Ограничение по времени: " + result.ToString("hh':'mm':'ss");
            timeText.Text = fromTimeString;

            test.triesCount = 1;

            triesText.Text = "Количество попыток: " + test.triesCount.ToString();

            Question question1 = new Question();
            question1.name = "Какое определение подходит под следующее описание";
            question1.description = "Разность между степенью и гладкостью сплайна";
            question1.answer = "дефект сплайна";
            Question question2 = new Question();
            question2.name = "Интерполирование кубическим сплайном";
            question2.description = "Какая степень сложности алгоритма метода Гаусса";
            question2.answer = "3";

            test.questions.Add(question1);
            test.questions.Add(question2);

            markLabel.Text = "";
        }
    }
}
