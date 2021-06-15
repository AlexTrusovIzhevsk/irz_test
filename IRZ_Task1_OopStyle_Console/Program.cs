using System;
using System.Configuration;

namespace IRZ_Task1_OopStyle_Classes
{
    public class Program
    {

        static void Main(string[] args)
        {
            var pathConfigurationXml = ConfigurationManager.AppSettings["pathConfigurationXml"];
            var reader = new ConsolePasswordReader();
            var validater = new PasswordValidater(PasswordConfigurationSerializer.Read(pathConfigurationXml));
            var passwordMandger = new PasswordMandgerForTestIrz(reader, validater);


            Console.Write("Create a password according to the rules.\n" +
                          "Rules:password is required\n " +
                          "1.Contains upper and lower case characters.\n" +
                          "2.Consist only of numbers, letters of the Latin alphabet, underscore, dash, period.\n" +
                          "3.At the beginning and at the end of the password, there must be Latin characters.\n" +
                          "4.The length of the password is from 8 to 25 characters.\n\n>");

            passwordMandger.Read();
            while (!passwordMandger.Validate())
            {
                Console.Write(
                    $"Invalid password! Use rule for password. Error: {passwordMandger.ValidateDescription()}. \n\n>");
                passwordMandger.Read();
            }

            Console.WriteLine("Valid password!");
            Console.ReadKey();

        }
    }
}