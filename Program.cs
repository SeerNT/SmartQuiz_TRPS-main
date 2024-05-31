namespace SmartQuiz
{
    internal static class Program
    {
        public static Authorization authForm;
        public static Registration registerForm;
        public static TestTypeChoice teacherNewTestForm;
        public static Questions questionsDesignerForm;
        public static TeacherMenu teacherMenu;
        public static TeacherTestResults teacherTestResults;
        public static QuestionEditor questionEditor;
        public static Feedback feedbackTeacher;
        public static TestChoice userTestsMenu;
        public static UserTest userTestForm;
        public static UserTestResults userTestResults;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            authForm = new Authorization();
            registerForm = new Registration();
            teacherNewTestForm = new TestTypeChoice();
            questionsDesignerForm = new Questions();
            teacherMenu = new TeacherMenu();
            teacherTestResults = new TeacherTestResults();
            questionEditor = new QuestionEditor();
            feedbackTeacher = new Feedback();
            userTestsMenu = new TestChoice();
            userTestForm = new UserTest();
            userTestResults = new UserTestResults();
            authForm.Show();
            Application.Run();
        }
    }
}