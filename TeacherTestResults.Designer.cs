namespace SmartQuiz
{
    partial class TeacherTestResults
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
            label3 = new Label();
            choice_combo_box = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            accept_button = new RoundButton();
            showFeedbackButton = new RoundButton();
            SuspendLayout();
            // 
            // new_test_label
            // 
            new_test_label.AutoSize = true;
            new_test_label.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            new_test_label.Location = new Point(12, 25);
            new_test_label.Name = "new_test_label";
            new_test_label.RightToLeft = RightToLeft.No;
            new_test_label.Size = new Size(361, 32);
            new_test_label.TabIndex = 18;
            new_test_label.Text = "Результаты тестирования";
            new_test_label.Click += new_test_label_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(61, 27);
            label3.TabIndex = 22;
            label3.Text = "Тест";
            // 
            // choice_combo_box
            // 
            choice_combo_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            choice_combo_box.FormattingEnabled = true;
            choice_combo_box.Location = new Point(21, 120);
            choice_combo_box.Margin = new Padding(2, 1, 2, 1);
            choice_combo_box.Name = "choice_combo_box";
            choice_combo_box.Size = new Size(142, 23);
            choice_combo_box.TabIndex = 23;
            choice_combo_box.Text = "Название теста...";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(224, 120);
            comboBox1.Margin = new Padding(2, 1, 2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 25;
            comboBox1.Text = "Название группы...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(215, 83);
            label1.Name = "label1";
            label1.Size = new Size(89, 27);
            label1.TabIndex = 24;
            label1.Text = "Группа";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.1818161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.818182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.Location = new Point(21, 177);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(391, 168);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // accept_button
            // 
            accept_button.BackColor = SystemColors.ControlText;
            accept_button.Font = new Font("Arial", 16.125F, FontStyle.Italic, GraphicsUnit.Point);
            accept_button.ForeColor = SystemColors.ControlLightLight;
            accept_button.Location = new Point(21, 388);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(211, 38);
            accept_button.TabIndex = 27;
            accept_button.Text = "Подтвердить";
            accept_button.UseVisualStyleBackColor = false;
            accept_button.Click += accept_button_Click;
            // 
            // showFeedbackButton
            // 
            showFeedbackButton.BackColor = SystemColors.ControlText;
            showFeedbackButton.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            showFeedbackButton.ForeColor = SystemColors.ControlLightLight;
            showFeedbackButton.Location = new Point(261, 388);
            showFeedbackButton.Name = "showFeedbackButton";
            showFeedbackButton.Size = new Size(211, 32);
            showFeedbackButton.TabIndex = 28;
            showFeedbackButton.Text = "Обратная связь";
            showFeedbackButton.UseVisualStyleBackColor = false;
            showFeedbackButton.Click += showFeedbackButton_Click;
            // 
            // TeacherTestResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(showFeedbackButton);
            Controls.Add(accept_button);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(choice_combo_box);
            Controls.Add(label3);
            Controls.Add(new_test_label);
            Name = "TeacherTestResults";
            Text = "Статистика результатов тестирования";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label new_test_label;
        private Label label3;
        private ComboBox choice_combo_box;
        private ComboBox comboBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private RoundButton accept_button;
        private RoundButton showFeedbackButton;
    }
}