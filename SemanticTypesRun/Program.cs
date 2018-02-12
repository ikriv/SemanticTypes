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

            Console.WriteLine("Sending email to " + email.Value);
        }

        private static void Login(SString<UserName> user)
        {
            Console.WriteLine("Login user: " + user.Value);
        }

        static void Main(string[] args)
        {
            Send("ivan@example.com".AsEmail());
            Send("bla@foobar.com".AsEmail());
            Login("ivan".As<UserName>());
        }
    }
}
