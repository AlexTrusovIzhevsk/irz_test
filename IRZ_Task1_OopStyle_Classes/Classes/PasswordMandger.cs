namespace IRZ_Task1_OopStyle_Classes
{
    public class PasswordMandgerForTestIrz : IPasswordManageable
    {
        private IPasswordReadeble PasswordReader;
        private IPasswordValidatable PasswordValidator;
        private string possiblePassword;

        public PasswordMandgerForTestIrz(IPasswordReadeble passwordReader, IPasswordValidatable passwordValidator)
        {
            PasswordReader = passwordReader;
            PasswordValidator = passwordValidator;
        }

        public void Read() => possiblePassword = PasswordReader.Read();

        public bool Validate() => PasswordValidator.Validate(possiblePassword);

        public ValidateDescription ValidateDescription() => PasswordValidator.GetValidateDescription();
    }
}