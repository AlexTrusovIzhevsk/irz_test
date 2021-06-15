namespace IRZ_Task1_OopStyle_Classes
{
    public interface IPasswordValidatable
    {
        bool Validate(string possiblePassword);
        ValidateDescription GetValidateDescription();
    }
}