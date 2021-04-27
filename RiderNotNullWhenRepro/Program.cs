using System;

namespace RiderNotNullWhenRepro
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = PasswordChecker.MySecurePasswordChecker("test", "123", out var user);

            if (!result)
            {
                Console.WriteLine("Invalid username/password");
            }
            
            // Rider gives a "Dereference of a possibly null reference." warning here on user
            Console.WriteLine($"Welcome, {user.Username}");
        }
    }
}
