namespace SmartQuiz
{
    partial class TestChoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            new_test_label = new Label();
            testName = new Label();
            timeText = new Label();
            triesText = new Label();
            startTest = new RoundButton();
            label4 = new Label();
            roundButton1 = new RoundButton();
            markText = new Label();
            markLabel = new Label();
            SuspendLayout();
            // 
            // new_test_label
            // 
            new_test_label.AutoSize = true;
            new_test_label.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            new_test_label.Location = new Point(12, 19);
            new_test_label.Name = "new_test_label";
            new_test_label.RightToLeft = RightToLeft.No;
            new_test_label.Size = new Size(210, 32);
            new_test_label.TabIndex = 17;
            new_test_label.Text = "Выберете тест";
            // 
            // testName
            // 
            testName.AutoSize = true;
            testName.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            testName.Location = new Point(12, 77);
            testName.Name = "testName";
            testName.Size = new Size(231, 27);
            testName.TabIndex = 21;
            testName.Text = "Название теста №1";
            // 
            // timeText
            // 
            timeText.AutoSize = true;
            timeText.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            timeText.Location = new Point(12, 130);
            timeText.Name = "timeText";
            timeText.Size = new Size(317, 22);
            timeText.TabIndex = 23;
            timeText.Text = "Ограничение по времени: 01:00:00";
            // 
            // triesText
            // 
            triesText.AutoSize = true;
            triesText.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            triesText.Location = new Point(12, 170);
            triesText.Name = "triesText";
            triesText.Size = new Size(208, 22);
            triesText.TabIndex = 24;
            triesText.Text = "Количество попыток: 3";
            // 
            // startTest
            // 
            startTest.BackColor = SystemColors.ControlText;
            startTest.Font = new Font("Arial", 16.125F, FontStyle.Italic, GraphicsUnit.Point);
            startTest.ForeColor = SystemColors.ControlLightLight;
            startTest.Location = new Point(12, 220);
            startTest.Name = "startTest";
            startTest.Size = new Size(289, 38);
            startTest.TabIndex = 25;
            startTest.Text = "Начать тестирование";
            startTest.UseVisualStyleBackColor = false;
            startTest.Click += startTest_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(315, 9);
            label4.Name = "label4";
            label4.Size = new Size(213, 22);
            label4.TabIndex = 26;
            label4.Text = "Мягков А.С. АДБ-21-02";
            // 
            // roundButton1
            // 
            roundButton1.BackColor = SystemColors.ControlText;
            roundButton1.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            roundButton1.ForeColor = SystemColors.ControlLightLight;
            roundButton1.Location = new Point(534, 5);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(109, 30);
            roundButton1.TabIndex = 27;
            roundButton1.Text = "Выход";
            roundButton1.UseVisualStyleBackColor = false;
            roundButton1.Click += roundButton1_Click;
            // 
            // markText
            // 
            markText.AutoSize = true;
            markText.ForeColor = Color.Chartreuse;
            markText.Location = new Point(12, 177);
            markText.Name = "markText";
            markText.Size = new Size(0, 15);
            markText.TabIndex = 28;
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            markLabel.ForeColor = Color.ForestGreen;
            markLabel.Location = new Point(12, 177);
            markLabel.Name = "markLabel";
            markLabel.Size = new Size(0, 22);
            markLabel.TabIndex = 29;
            // 
            // TestChoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 279);
            Controls.Add(markLabel);
            Controls.Add(markText);
            Controls.Add(roundButton1);
            Controls.Add(label4);
            Controls.Add(startTest);
            Controls.Add(triesText);
            Controls.Add(timeText);
            Controls.Add(testName);
            Controls.Add(new_test_label);
            Name = "TestChoice";
            Text = "Выбор тестирования";
            Load += TestChoice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label new_test_label;
        private Label testName;
        private Label timeText;
        private Label triesText;
        private RoundButton startTest;
        private Label label4;
        private RoundButton roundButton1;
        private Label markText;
        private Label markLabel;
    }
}