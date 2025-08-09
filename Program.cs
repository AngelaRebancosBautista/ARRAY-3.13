using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emails = new string[5];

            Console.WriteLine("Enter 5 email addresses");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Email {i + 1}: ");
                emails[i] = Console.ReadLine();
            }
            Console.WriteLine("\nValidation Results");

            foreach (string email in emails)
            {
                if (IsValidEmail(email))
                {
                    string username = ExtractUsername(email);
                    Console.WriteLine($"Valid: {email} => Username: {username}");
                }
                else
                {
                    Console.WriteLine($"Invalid: {email}");
                }
            }
        }
        static bool IsValidEmail(string email)
        {
            return email.Contains("@") && (email.EndsWith(".com") || email.EndsWith(".edu"));
        }
        static string ExtractUsername(string email)
        {
            int atIndex = email.IndexOf('@');
            return email.Substring(0, atIndex);
        }
    }
}
        

