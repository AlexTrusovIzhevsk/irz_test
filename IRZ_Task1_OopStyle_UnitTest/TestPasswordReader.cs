namespace IRZ_Task1_OopStyle_Classes
{
    public class TestPasswordReader : IPasswordReadeble
    {
        private string testPassword;

        public TestPasswordReader(string testPassword)
        {
            this.testPassword = testPassword;
        }

        public string Read() => testPassword;
    }
}