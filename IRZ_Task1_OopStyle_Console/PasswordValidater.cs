using System.Linq;

namespace IRZ_Task1_OopStyle_Classes
{
    public class PasswordValidater : IPasswordValidatable
    {
        private readonly PasswordValidateConfiguration configuration;
        private ValidateDescription validateDescription;

        public PasswordValidater(PasswordValidateConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public bool Validate(string possiblePassword)
        {
            if (possiblePassword is null)
            {
                throw new ValidatePossibleException($"argument {nameof(possiblePassword)} is null");
            }

            if (configuration.MinLength > possiblePassword.Length)
            {
                validateDescription = ValidateDescription.LengthLessThanMinLength;
            }
            else if (configuration.MaxLength < possiblePassword.Length)
            {
                validateDescription = ValidateDescription.LengthMoreThanMaxLength;
            }
            else if(!configuration.StartChars.Contains(possiblePassword.First()))
            {
                validateDescription = ValidateDescription.StartCharactersNotLatin;
            }
            else if (!configuration.EndChars.Contains(possiblePassword.Last()))
            {
                validateDescription = ValidateDescription.EndCharactersNotLatin;
            }
            else if (!CheckPassworConteinsAnyCharFromAllGroupe(possiblePassword, configuration.GroupeMastChars))
            {
                validateDescription = ValidateDescription.NotContainsCharacterFromGrupeMastCharacters;
            }
            else if (!possiblePassword.All(ch => configuration.Chars.Contains(ch)))
            {
                validateDescription = ValidateDescription.ConsistNotOnlyNumbersLettersLatinAlphabetUnderscoreDashDot;
            }
            else
            {
                validateDescription = ValidateDescription.Correct;
            }
            return (int)validateDescription == 1 ;
        }

        private bool CheckPassworConteinsAnyCharFromAllGroupe(string possiblePassword, char[][] GroupeMastChars) => 
            GroupeMastChars
                .All(groupe => groupe
                    .Any(ch => possiblePassword.Contains(ch)));

        public ValidateDescription GetValidateDescription() => validateDescription;
    }
}