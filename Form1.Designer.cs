using System.Drawing.Drawing2D;

namespace SmartQuiz
{
    public class RoundButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float m = 2.75F;
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X + m, Rect.Y + m, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2 + m, Rect.Y + m, Rect.Width - r2 - m, Rect.Y + m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m, Rect.Y + m, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width - m, Rect.Y + r2, Rect.Width - m, Rect.Height - r2 - m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m,
                           Rect.Y + Rect.Height - radius - m, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2 - m, Rect.Height - m, Rect.X + r2 - m, Rect.Height - m);
            GraphPath.AddArc(Rect.X + m, Rect.Y + Rect.Height - radius - m, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X + m, Rect.Height - r2 - m, Rect.X + m, Rect.Y + r2 + m);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Здесь параметры округлости кнопки
            int borderRadius = 15;
            float borderThickness = 1.75f;
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, borderRadius);

            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(Color.Silver, borderThickness))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }
    }

    partial class Authorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new Label();
            password = new Label();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            auth_label = new Label();
            loginBut = new RoundButton();
            registerBut = new RoundButton();
            SuspendLayout();
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(150, 104);
            login.Name = "login";
            login.Size = new Size(92, 29);
            login.TabIndex = 0;
            login.Text = "Логин:";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(150, 153);
            password.Name = "password";
            password.Size = new Size(109, 29);
            password.TabIndex = 1;
            password.Text = "Пароль:";
            // 
            // loginBox
            // 
            loginBox.BorderStyle = BorderStyle.FixedSingle;
            loginBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginBox.Location = new Point(285, 104);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(220, 27);
            loginBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(285, 153);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(220, 27);
            passwordBox.TabIndex = 3;
            // 
            // auth_label
            // 
            auth_label.Anchor = AnchorStyles.None;
            auth_label.AutoSize = true;
            auth_label.Font = new Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point);
            auth_label.Location = new Point(192, 34);
            auth_label.Margin = new Padding(3, 3, 3, 3);
            auth_label.Name = "auth_label";
            auth_label.Size = new Size(255, 41);
            auth_label.TabIndex = 6;
            auth_label.Text = "Авторизация:";
            auth_label.Click += auth_label_Click;
            // 
            // loginBut
            // 
            loginBut.BackColor = Color.Black;
            loginBut.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            loginBut.ForeColor = Color.White;
            loginBut.Location = new Point(177, 202);
            loginBut.Name = "loginBut";
            loginBut.Size = new Size(75, 32);
            loginBut.TabIndex = 4;
            loginBut.Text = "Вход";
            loginBut.UseVisualStyleBackColor = false;
            loginBut.Click += loginBut_Click;
            // 
            // registerBut
            // 
            registerBut.BackColor = Color.Black;
            registerBut.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            registerBut.ForeColor = Color.White;
            registerBut.Location = new Point(317, 202);
            registerBut.Name = "registerBut";
            registerBut.Size = new Size(159, 32);
            registerBut.TabIndex = 5;
            registerBut.Text = "Регистрация";
            registerBut.UseVisualStyleBackColor = false;
            registerBut.Click += registerBut_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(669, 366);
            Controls.Add(auth_label);
            Controls.Add(registerBut);
            Controls.Add(loginBut);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(password);
            Controls.Add(login);
            Name = "Authorization";
            Text = "Авторизация";
            FormClosed += Authorization_FormClosed;
            Load += Authorization_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login;
        private Label password;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Label auth_label;
        private RoundButton loginBut;
        private RoundButton registerBut;

        public TextBox currLogin()
        {
            return loginBox;
        }

        public TextBox currPassword()
        {
            return passwordBox;
        }
    }

    
}
