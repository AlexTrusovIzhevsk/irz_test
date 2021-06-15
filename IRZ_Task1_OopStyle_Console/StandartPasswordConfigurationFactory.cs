using System.Linq;

namespace IRZ_Task1_OopStyle_Classes
{
    public static class StandartPasswordConfigurationFactory
    {
        public static PasswordValidateConfiguration CreateStandartConfiguration()
            => new PasswordValidateConfiguration(8, 25, chars, startChars, endChars, GroupeMastChars);

        private static char[] chars;
        private static char[] startChars;
        private static char[] endChars;
        private static char[][] GroupeMastChars;

        static StandartPasswordConfigurationFactory()
        {
            var lettersLower = GetCharsRange('a', 'z').ToArray();
            var lettersUpper = GetCharsRange('A', 'Z').ToArray();
            var letters = lettersLower.Concat(lettersUpper).ToArray();
            var digit = GetCharsRange('0', '9');
            var bonusChar = new[] { '_', '-', '.' };

            chars = letters
                .Concat(digit)
                .Concat(bonusChar)
                .ToArray();

            startChars = endChars = letters;

            GroupeMastChars = new[] { lettersLower, lettersUpper };
        }

        private static char[] GetCharsRange(char start, char end) => Enumerable.Range(start, end - start + 1).Select(i => (char)i).ToArray();
    }
}