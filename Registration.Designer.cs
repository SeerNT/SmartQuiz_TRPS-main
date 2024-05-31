namespace SmartQuiz
{
    partial class Registration
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
            confirmRegisterBut = new RoundButton();
            passwordBox = new TextBox();
            loginBox = new TextBox();
            password = new Label();
            login = new Label();
            textBox1 = new TextBox();
            auth_label = new Label();
            registration_label = new Label();
            SuspendLayout();
            // 
            // confirmRegisterBut
            // 
            confirmRegisterBut.BackColor = SystemColors.ControlText;
            confirmRegisterBut.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirmRegisterBut.ForeColor = SystemColors.ControlLightLight;
            confirmRegisterBut.Location = new Point(400, 629);
            confirmRegisterBut.Margin = new Padding(6);
            confirmRegisterBut.Name = "confirmRegisterBut";
            confirmRegisterBut.Size = new Size(443, 78);
            confirmRegisterBut.TabIndex = 11;
            confirmRegisterBut.Text = "Зарегистрироваться";
            confirmRegisterBut.UseVisualStyleBackColor = false;
            confirmRegisterBut.Click += confirmRegisterBut_Click;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(529, 326);
            passwordBox.Margin = new Padding(6);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(407, 47);
            passwordBox.TabIndex = 9;
            // 
            // loginBox
            // 
            loginBox.BorderStyle = BorderStyle.FixedSingle;
            loginBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginBox.Location = new Point(529, 222);
            loginBox.Margin = new Padding(6);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(407, 47);
            loginBox.TabIndex = 8;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(279, 326);
            password.Margin = new Padding(6, 0, 6, 0);
            password.Name = "password";
            password.Size = new Size(221, 56);
            password.TabIndex = 7;
            password.Text = "Пароль:";
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(279, 222);
            login.Margin = new Padding(6, 0, 6, 0);
            login.Name = "login";
            login.Size = new Size(183, 56);
            login.TabIndex = 6;
            login.Text = "Логин:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(529, 431);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 47);
            textBox1.TabIndex = 13;
            // 
            // auth_label
            // 
            auth_label.AutoSize = true;
            auth_label.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            auth_label.Location = new Point(165, 431);
            auth_label.Margin = new Padding(6, 0, 6, 0);
            auth_label.Name = "auth_label";
            auth_label.Size = new Size(347, 112);
            auth_label.TabIndex = 12;
            auth_label.Text = "Подтвердите \r\nпароль:";
            auth_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // registration_label
            // 
            registration_label.AutoSize = true;
            registration_label.Font = new Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point);
            registration_label.Location = new Point(387, 76);
            registration_label.Margin = new Padding(6, 0, 6, 0);
            registration_label.Name = "registration_label";
            registration_label.Size = new Size(495, 81);
            registration_label.TabIndex = 14;
            registration_label.Text = "Регистрация:";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 815);
            Controls.Add(registration_label);
            Controls.Add(textBox1);
            Controls.Add(auth_label);
            Controls.Add(confirmRegisterBut);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(password);
            Controls.Add(login);
            Margin = new Padding(6);
            Name = "Registration";
            Text = "Регистрация";
            FormClosed += Registration_FormClosed;
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passwordBox;
        private TextBox loginBox;
        private Label password;
        private Label login;
        private TextBox textBox1;
        private Label auth_label;
        private Label registration_label;
        private RoundButton confirmRegisterBut;
    }
}