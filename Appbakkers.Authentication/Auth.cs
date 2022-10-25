using System;
using Xamarin.Essentials;

namespace Appbakkers.Authentication
{
    public class Auth
    {
        public static bool Check()
        {
            var token = Preferences.Get("access_token", "", "authentication");

            return !string.IsNullOrEmpty(token);
        }

        public static void Init(string clientId, string clientSecret)
        {
            //
        }

        public static void Login(string username, string password)
        {
            Preferences.Set("access_token", "test", "authentication");
        }

        public static void Logout()
        {
            Preferences.Clear("authentication");
        }
    }
}
