using System;

namespace IRZ_Task1_OopStyle_Classes
{
    public class ConsolePasswordReader : IPasswordReadeble
    {
        public string Read() => Console.ReadLine();
    }
}
