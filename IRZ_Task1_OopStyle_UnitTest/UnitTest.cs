using IRZ_Task1_OopStyle_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IRZ_Task1_OopStyle_UnitTest
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void ValidatePossiblePassword_IsCorrect_Ok()
        {
            var passwordMandger = CreatePasswordMandger("qwertyQWERTY12345qwerty", StandartPasswordConfigurationFactory.CreateStandartConfiguration());

            passwordMandger.Read();
            var isValidate = passwordMandger.Validate();
            var description = passwordMandger.ValidateDescription();

            Assert.IsTrue(isValidate);
            Assert.AreEqual(ValidateDescription.Correct, description);
        }

        [TestMethod]
        public void ValidatePossiblePassword_Short_Invalid()
        {
            var passwordMandger = CreatePasswordMandger("qQ1q", StandartPasswordConfigurationFactory.CreateStandartConfiguration());

            passwordMandger.Read();
            var isValidate = passwordMandger.Validate();
            var description = passwordMandger.ValidateDescription();

            Assert.IsFalse(isValidate);
            Assert.AreEqual(ValidateDescription.LengthLessThanMinLength, description);
        }

        [TestMethod]
        public void ValidatePossiblePassword_Long_Invalid()
        {
            var passwordMandgerForTestIrz = CreatePasswordMandger("qwertyQWERTY12345qwertyQWERTY12345qwerty", StandartPasswordConfigurationFactory.CreateStandartConfiguration());

            passwordMandgerForTestIrz.Read();
            var isValidate = passwordMandgerForTestIrz.Validate();
            var description = passwordMandgerForTestIrz.ValidateDescription();

            Assert.IsFalse(isValidate);
            Assert.AreEqual(ValidateDescription.LengthMoreThanMaxLength, description);
        }

        [TestMethod]
        public void ValidatePossiblePassword_StartIsNotLetter_Invalid()
        {
            var passwordMandgerForTestIrz = CreatePasswordMandger("1qwertyQWERTY12345qwerty", StandartPasswordConfigurationFactory.CreateStandartConfiguration());

            passwordMandgerForTestIrz.Read();
            var isValidate = passwordMandgerForTestIrz.Validate();
            var description = passwordMandgerForTestIrz.ValidateDescription();

            Assert.IsFalse(isValidate);
            Assert.AreEqual(ValidateDescription.StartCharactersNotLatin, description);
        }

        [TestMethod]
        public void ValidatePossiblePassword_EndIsNotLetter_Invalid()
        {
            var passwordMandgerForTestIrz = CreatePasswordMandger("qwertyQWERTY12345qwerty1", StandartPasswordConfigurationFactory.CreateStandartConfiguration());

            passwordMandgerForTestIrz.Read();
            var isValidate = passwordMandgerForTestIrz.Validate();
            var description = passwordMandgerForTestIrz.ValidateDescription();

            Assert.IsFalse(isValidate);
            Assert.AreEqual(ValidateDescription.EndCharactersNotLatin, description);
        }

        [TestMethod]
        public void ValidatePossiblePassword_NotContainsUpperLetter_Invalid()
        {
            var passwordMandgerForTestIrz = CreatePasswordMandger("qwertyqwerty12345qwerty", StandartPasswordConfigurationFactory.CreateStandartConfiguration());

            passwordMandgerForTestIrz.Read();
            var isValidate = passwordMandgerForTestIrz.Validate();
            var description = passwordMandgerForTestIrz.ValidateDescription();

            Assert.IsFalse(isValidate);
            Assert.AreEqual(ValidateDescription.NotContainsCharacterFromGrupeMastCharacters, description);
        }

        [TestMethod]
        public void ValidatePossiblePassword_NotContainsLowLetter_Invalid()
        {
            var passwordMandgerForTestIrz = CreatePasswordMandger("QWERTYQWERTY12345QWERTY", StandartPasswordConfigurationFactory.CreateStandartConfiguration());

            passwordMandgerForTestIrz.Read();
            var isValidate = passwordMandgerForTestIrz.Validate();
            var description = passwordMandgerForTestIrz.ValidateDescription();

            Assert.IsFalse(isValidate);
            Assert.AreEqual(ValidateDescription.NotContainsCharacterFromGrupeMastCharacters, description);
        }

        [TestMethod]
        public void ValidatePossiblePassword_ContainsInvalidCharacter_Invalid()
        {
            var passwordMandgerForTestIrz = CreatePasswordMandger("qwertyQWERTY12345+qwerty", StandartPasswordConfigurationFactory.CreateStandartConfiguration());

            passwordMandgerForTestIrz.Read();
            var isValidate = passwordMandgerForTestIrz.Validate();
            var description = passwordMandgerForTestIrz.ValidateDescription();

            Assert.IsFalse(isValidate);
            Assert.AreEqual(ValidateDescription.ConsistNotOnlyNumbersLettersLatinAlphabetUnderscoreDashDot, description);
        }

        private PasswordMandgerForTestIrz CreatePasswordMandger(string password, PasswordValidateConfiguration configuration)
        {
            var reader = new TestPasswordReader(password);
            var validator = new PasswordValidater(configuration);
            var passwordMandgerForTestIrz = new PasswordMandgerForTestIrz(reader, validator);
            return passwordMandgerForTestIrz;
        }
    }
}
