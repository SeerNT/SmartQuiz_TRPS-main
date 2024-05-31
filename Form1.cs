namespace SmartQuiz
{
    public partial class Authorization : Form
    {
        List<User> users = new List<User>();

        public Authorization()
        {
            InitializeComponent();
        }

        private void registerBut_Click(object sender, EventArgs e)
        {
            Program.authForm.Hide();
            Program.registerForm.Show();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void auth_label_Click(object sender, EventArgs e)
        {

        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            if (Program.authForm.currLogin().Text == "admin" && Program.authForm.currPassword().Text == "admin")
            {
                Program.authForm.Hide();
                Program.teacherMenu.Show();
                return;
            }
            else
            {
                User tempUser = new User();
                tempUser = new User();
                tempUser.login = Program.authForm.currLogin().Text;
                tempUser.password = Program.authForm.currPassword().Text;

                if (users.Contains(tempUser))
                {
                    Program.authForm.Hide();
                    Program.userTestsMenu.Show();
                }   
            } 
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            var logFile = File.ReadAllLines("usersData.txt");
            List<string> logList = new List<string>(logFile);
            int lineNum = 0;
            
            User tempUser = new User();

            for (int i = 0; i < logList.Count; i++)
            {
                lineNum++;
                if (lineNum == 1)
                {
                    tempUser = new User();
                }
                if(lineNum == 2)
                {
                    tempUser.login = logList[i+1];
                }
                if (lineNum == 3)
                {
                    tempUser.password = logList[i + 1];
                }
                if (lineNum == 4)
                {
                    users.Add(tempUser);
                }
            }
        }
    }
}

