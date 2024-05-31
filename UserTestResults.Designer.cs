namespace SmartQuiz
{
    partial class UserTestResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTestResults));
            label5 = new Label();
            label1 = new Label();
            end_test_button = new RoundButton();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            auth_label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(17, 325);
            label5.Name = "label5";
            label5.Size = new Size(157, 19);
            label5.TabIndex = 24;
            label5.Text = "Правильный ответ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 284);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 23;
            label1.Text = "Введённый ответ:";
            // 
            // end_test_button
            // 
            end_test_button.BackColor = SystemColors.ControlText;
            end_test_button.Font = new Font("Arial", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            end_test_button.ForeColor = SystemColors.ControlLightLight;
            end_test_button.Location = new Point(496, 342);
            end_test_button.Name = "end_test_button";
            end_test_button.Size = new Size(162, 37);
            end_test_button.TabIndex = 22;
            end_test_button.Text = "Завершить";
            end_test_button.UseVisualStyleBackColor = false;
            end_test_button.Click += end_test_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(538, 25);
            label4.Name = "label4";
            label4.Size = new Size(114, 22);
            label4.TabIndex = 21;
            label4.Text = "Итого: 0/30";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(338, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 229);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(75, 37);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 19;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(46, 38);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 18;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 170, 214);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(17, 38);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 17;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 12);
            label3.Name = "label3";
            label3.Size = new Size(294, 22);
            label3.TabIndex = 16;
            label3.Text = "Название теста (10 вопросов)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 108);
            label2.Name = "label2";
            label2.Size = new Size(152, 19);
            label2.TabIndex = 15;
            label2.Text = "Описание вопроса";
            // 
            // auth_label
            // 
            auth_label.AutoSize = true;
            auth_label.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            auth_label.Location = new Point(13, 81);
            auth_label.Name = "auth_label";
            auth_label.Size = new Size(197, 22);
            auth_label.TabIndex = 14;
            auth_label.Text = "Заголовок вопроса";
            // 
            // UserTestResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 414);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(end_test_button);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(auth_label);
            Name = "UserTestResults";
            Text = "Просмотр результатов";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private RoundButton end_test_button;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label auth_label;
    }
}