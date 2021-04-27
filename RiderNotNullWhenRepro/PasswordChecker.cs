using System.Diagnostics.CodeAnalysis;

namespace RiderNotNullWhenRepro
{
    public class PasswordChecker
    {
        public static bool MySecurePasswordChecker(string username, string password, [NotNullWhen(true)] out User? user)
        {
            if (username == "helloworld")
            {
                user = new User
                {
                    Username = "helloworld",
                };

                return true;
            }

            user = null;
            return false;
        }
    }
}
