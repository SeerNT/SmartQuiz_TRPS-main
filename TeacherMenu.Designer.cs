namespace SmartQuiz
{
    partial class TeacherMenu
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
            roundButton1 = new RoundButton();
            label4 = new Label();
            editTestButton = new RoundButton();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            new_test_label = new Label();
            showResultsButton = new RoundButton();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundButton1
            // 
            roundButton1.BackColor = SystemColors.ControlText;
            roundButton1.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            roundButton1.ForeColor = SystemColors.ControlLightLight;
            roundButton1.Location = new Point(534, 10);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(109, 30);
            roundButton1.TabIndex = 35;
            roundButton1.Text = "Выход";
            roundButton1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(470, 14);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 34;
            label4.Text = "ФИО ";
            // 
            // editTestButton
            // 
            editTestButton.BackColor = SystemColors.ControlText;
            editTestButton.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            editTestButton.ForeColor = SystemColors.ControlLightLight;
            editTestButton.Location = new Point(357, 128);
            editTestButton.Name = "editTestButton";
            editTestButton.Size = new Size(270, 37);
            editTestButton.TabIndex = 33;
            editTestButton.Text = "Редактировать";
            editTestButton.UseVisualStyleBackColor = false;
            editTestButton.Click += editTestButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 175);
            label2.Name = "label2";
            label2.Size = new Size(208, 22);
            label2.TabIndex = 32;
            label2.Text = "Количество попыток: 3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 135);
            label1.Name = "label1";
            label1.Size = new Size(317, 22);
            label1.TabIndex = 31;
            label1.Text = "Ограничение по времени: 01:00:00";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 46);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(72, 82);
            label3.Name = "label3";
            label3.Size = new Size(231, 27);
            label3.TabIndex = 29;
            label3.Text = "Название теста №1";
            // 
            // new_test_label
            // 
            new_test_label.AutoSize = true;
            new_test_label.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            new_test_label.Location = new Point(12, 24);
            new_test_label.Name = "new_test_label";
            new_test_label.RightToLeft = RightToLeft.No;
            new_test_label.Size = new Size(210, 32);
            new_test_label.TabIndex = 28;
            new_test_label.Text = "Выберете тест";
            // 
            // showResultsButton
            // 
            showResultsButton.BackColor = SystemColors.ControlText;
            showResultsButton.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            showResultsButton.ForeColor = SystemColors.ControlLightLight;
            showResultsButton.Location = new Point(357, 171);
            showResultsButton.Name = "showResultsButton";
            showResultsButton.Size = new Size(270, 37);
            showResultsButton.TabIndex = 36;
            showResultsButton.Text = "Просмотр результатов";
            showResultsButton.UseVisualStyleBackColor = false;
            showResultsButton.Click += showResultsButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(357, 82);
            label5.Name = "label5";
            label5.Size = new Size(67, 22);
            label5.TabIndex = 37;
            label5.Text = "Группа";
            // 
            // TeacherMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 214);
            Controls.Add(label5);
            Controls.Add(showResultsButton);
            Controls.Add(roundButton1);
            Controls.Add(label4);
            Controls.Add(editTestButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(new_test_label);
            Name = "TeacherMenu";
            Text = "TeacherMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundButton roundButton1;
        private Label label4;
        private RoundButton editTestButton;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label new_test_label;
        private RoundButton showResultsButton;
        private Label label5;
    }
}