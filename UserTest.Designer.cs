namespace SmartQuiz
{
    partial class UserTest
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
            components = new System.ComponentModel.Container();
            testLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timeLabel = new Label();
            end_test_button = new RoundButton();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1 = new TabControl();
            SuspendLayout();
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            testLabel.Location = new Point(12, 9);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(294, 22);
            testLabel.TabIndex = 3;
            testLabel.Text = "Название теста (10 вопросов)";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 170, 214);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(16, 35);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 4;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(45, 35);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 5;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(74, 34);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 6;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.Location = new Point(462, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(195, 22);
            timeLabel.TabIndex = 10;
            timeLabel.Text = "Осталось: 00:35:48";
            timeLabel.Click += label4_Click_1;
            // 
            // end_test_button
            // 
            end_test_button.BackColor = SystemColors.ControlText;
            end_test_button.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            end_test_button.ForeColor = SystemColors.ControlLightLight;
            end_test_button.Location = new Point(438, 339);
            end_test_button.Name = "end_test_button";
            end_test_button.Size = new Size(209, 52);
            end_test_button.TabIndex = 11;
            end_test_button.Text = "Завершить попытку";
            end_test_button.UseVisualStyleBackColor = false;
            end_test_button.Click += end_test_button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Location = new Point(12, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(641, 299);
            tabControl1.TabIndex = 16;
            // 
            // UserTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 393);
            Controls.Add(tabControl1);
            Controls.Add(end_test_button);
            Controls.Add(timeLabel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(testLabel);
            Name = "UserTest";
            Text = "Тест";
            Load += UserTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label testLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label timeLabel;
        private RoundButton end_test_button;
        private System.Windows.Forms.Timer timer1;
        private TabControl tabControl1;
    }
}