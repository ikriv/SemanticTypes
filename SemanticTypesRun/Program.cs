using System;
using SemanticTypes;

namespace SemanticTypesRun
{
    class Program
    {
        public static void Send(Email email)
        {
            if (email == "ivan@example.com".AsEmail())
            {
                Console.WriteLine("Cannot send");
                return;
            }

            Console.WriteLine("Sending email to " + email.Value);
        }

        static void Main(string[] args)
        {
            Send("ivan@example.com".AsEmail());
            Send("bla@foobar.com".AsEmail());
        }
    }
}
