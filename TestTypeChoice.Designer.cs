using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace SmartQuiz
{
    partial class TestTypeChoice
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
            choice_label = new Label();
            accept_button = new RoundButton();
            attempt_box = new TextBox();
            new_test_label = new Label();
            choice_combo_box = new ComboBox();
            time_limit_box = new TextBox();
            test_name_box = new TextBox();
            SuspendLayout();
            // 
            // choice_label
            // 
            choice_label.AutoSize = true;
            choice_label.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            choice_label.Location = new Point(36, 189);
            choice_label.Name = "choice_label";
            choice_label.Size = new Size(379, 32);
            choice_label.TabIndex = 5;
            choice_label.Text = "Выбор необходимого типа";
            // 
            // accept_button
            // 
            accept_button.BackColor = SystemColors.ControlText;
            accept_button.Font = new Font("Arial", 16.125F, FontStyle.Italic, GraphicsUnit.Point);
            accept_button.ForeColor = SystemColors.ControlLightLight;
            accept_button.Location = new Point(43, 294);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(208, 38);
            accept_button.TabIndex = 6;
            accept_button.Text = "Подтвердить";
            accept_button.UseVisualStyleBackColor = false;
            accept_button.Click += accept_button_Click;
            // 
            // attempt_box
            // 
            attempt_box.BorderStyle = BorderStyle.FixedSingle;
            attempt_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            attempt_box.Location = new Point(43, 115);
            attempt_box.Name = "attempt_box";
            attempt_box.PlaceholderText = "Количество попыток";
            attempt_box.Size = new Size(203, 23);
            attempt_box.TabIndex = 8;
            attempt_box.TextChanged += textBox2_TextChanged;
            // 
            // new_test_label
            // 
            new_test_label.AutoSize = true;
            new_test_label.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            new_test_label.Location = new Point(36, 26);
            new_test_label.Name = "new_test_label";
            new_test_label.RightToLeft = RightToLeft.No;
            new_test_label.Size = new Size(170, 32);
            new_test_label.TabIndex = 9;
            new_test_label.Text = "Новый тест";
            new_test_label.Click += label1_Click;
            // 
            // choice_combo_box
            // 
            choice_combo_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            choice_combo_box.FormattingEnabled = true;
            choice_combo_box.Location = new Point(43, 239);
            choice_combo_box.Margin = new Padding(2, 1, 2, 1);
            choice_combo_box.Name = "choice_combo_box";
            choice_combo_box.Size = new Size(192, 23);
            choice_combo_box.TabIndex = 10;
            choice_combo_box.Text = "Множественный выбор...";
            choice_combo_box.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // time_limit_box
            // 
            time_limit_box.BorderStyle = BorderStyle.FixedSingle;
            time_limit_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            time_limit_box.Location = new Point(43, 149);
            time_limit_box.Name = "time_limit_box";
            time_limit_box.PlaceholderText = "Лимит времени";
            time_limit_box.Size = new Size(203, 23);
            time_limit_box.TabIndex = 11;
            time_limit_box.TextChanged += textBox3_TextChanged;
            // 
            // test_name_box
            // 
            test_name_box.BorderStyle = BorderStyle.FixedSingle;
            test_name_box.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            test_name_box.Location = new Point(43, 80);
            test_name_box.Name = "test_name_box";
            test_name_box.PlaceholderText = "Название теста";
            test_name_box.Size = new Size(203, 23);
            test_name_box.TabIndex = 12;
            // 
            // TestTypeChoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 366);
            Controls.Add(test_name_box);
            Controls.Add(time_limit_box);
            Controls.Add(choice_combo_box);
            Controls.Add(new_test_label);
            Controls.Add(attempt_box);
            Controls.Add(accept_button);
            Controls.Add(choice_label);
            Name = "TestTypeChoice";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Создание нового теста";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label choice_label;
        private RoundButton accept_button;
        private TextBox attempt_box;
        private Label new_test_label;
        private ComboBox choice_combo_box;
        private TextBox time_limit_box;

        private TextBox test_name_box;
    }
}