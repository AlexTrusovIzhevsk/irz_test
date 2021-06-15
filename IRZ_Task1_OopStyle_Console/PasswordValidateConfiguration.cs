using System;

namespace IRZ_Task1_OopStyle_Classes
{
    [Serializable]
    public class PasswordValidateConfiguration
    {
        public int MinLength;
        public int MaxLength;
        public char[] Chars;
        public char[] StartChars;
        public char[] EndChars;
        public char[][] GroupeMastChars;

        public PasswordValidateConfiguration(
            int minLength, 
            int maxLength, 
            char[] chars, 
            char[] startChars, 
            char[] endChars, 
            char[][] groupeMastChars)
        {
            MinLength = minLength;
            MaxLength = maxLength;
            Chars = chars;
            StartChars = startChars;
            EndChars = endChars;
            GroupeMastChars = groupeMastChars;
        }

        public PasswordValidateConfiguration()
        {
            
        }
    }
}
