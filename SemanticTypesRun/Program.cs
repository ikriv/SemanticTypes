using System;
using SemanticTypes;

namespace SemanticTypesRun
{
    class Program
    {
        enum UserName {}


        public static void Send(Email email)
        {
            if (email == "ivan@example.com".AsEmail())
            {
                Console.WriteLine("Cannot send");
                return;
            }

            Console.WriteLine("Sending email to " + email);
        }

        private static void Login(SString<UserName> user)
        {
            Console.WriteLine("Login user: " + user);
        }

        public static void ShowSquare(Length a, Length b)
        {
            Console.WriteLine($"Rectangle with sides of {a} and {b} has the same area as a square with side of {(a*b).Sqrt()}");
        }

        static void Main(string[] args)
        {
            Send("ivan@example.com".AsEmail());
            Send("bla@foobar.com".AsEmail());
            Login("ivan".As<UserName>());
            ShowSquare(9.0.AsLength(), 4.0.AsLength());
        }
    }
}
