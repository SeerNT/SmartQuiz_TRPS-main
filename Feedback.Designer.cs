namespace SmartQuiz
{
    partial class Feedback
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
            choice_combo_box = new ComboBox();
            new_test_label = new Label();
            sendFeedbackButton = new RoundButton();
            label3 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // choice_combo_box
            // 
            choice_combo_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            choice_combo_box.FormattingEnabled = true;
            choice_combo_box.Location = new Point(19, 105);
            choice_combo_box.Margin = new Padding(2, 1, 2, 1);
            choice_combo_box.Name = "choice_combo_box";
            choice_combo_box.Size = new Size(142, 23);
            choice_combo_box.TabIndex = 17;
            choice_combo_box.Text = "Название группы...";
            // 
            // new_test_label
            // 
            new_test_label.AutoSize = true;
            new_test_label.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            new_test_label.Location = new Point(12, 23);
            new_test_label.Name = "new_test_label";
            new_test_label.RightToLeft = RightToLeft.No;
            new_test_label.Size = new Size(229, 32);
            new_test_label.TabIndex = 16;
            new_test_label.Text = "Обратная связь";
            // 
            // sendFeedbackButton
            // 
            sendFeedbackButton.BackColor = SystemColors.ControlText;
            sendFeedbackButton.Font = new Font("Arial", 16.125F, FontStyle.Italic, GraphicsUnit.Point);
            sendFeedbackButton.ForeColor = SystemColors.ControlLightLight;
            sendFeedbackButton.Location = new Point(19, 503);
            sendFeedbackButton.Name = "sendFeedbackButton";
            sendFeedbackButton.Size = new Size(208, 38);
            sendFeedbackButton.TabIndex = 14;
            sendFeedbackButton.Text = "Отправить";
            sendFeedbackButton.UseVisualStyleBackColor = false;
            sendFeedbackButton.Click += sendFeedbackButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 68);
            label3.Name = "label3";
            label3.Size = new Size(74, 24);
            label3.TabIndex = 20;
            label3.Text = "Группа";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 149);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 22;
            label1.Text = "Ученик";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(19, 186);
            comboBox1.Margin = new Padding(2, 1, 2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "ФИО Ученика...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 226);
            label2.Name = "label2";
            label2.Size = new Size(54, 24);
            label2.TabIndex = 24;
            label2.Text = "Тест";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(19, 263);
            comboBox2.Margin = new Padding(2, 1, 2, 1);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(142, 23);
            comboBox2.TabIndex = 23;
            comboBox2.Text = "Название теста...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 310);
            label4.Name = "label4";
            label4.Size = new Size(138, 24);
            label4.TabIndex = 25;
            label4.Text = "Комментарий";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 346);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 142);
            textBox2.TabIndex = 26;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 551);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(choice_combo_box);
            Controls.Add(new_test_label);
            Controls.Add(sendFeedbackButton);
            Name = "Feedback";
            Text = "Обратная связь";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox choice_combo_box;
        private Label new_test_label;
        private RoundButton sendFeedbackButton;
        private Label label3;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox2;
    }
}