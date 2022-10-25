using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;

namespace Appbakkers.Authentication.Android
{
    [Activity(Label = "Sanctum")]
    public class SanctumActivity : AppCompatActivity
    {
        EditText editTextUsername;
        EditText editTextPassword;
        Button buttonLogin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ActivityLogin);

            Auth.Init("2", "bLQnoP9vjT8FHE13oVkzEfbXVI8IUKXedwm7p66r");

            editTextUsername = FindViewById<EditText>(Resource.Id.EditTextUsername);
            editTextPassword = FindViewById<EditText>(Resource.Id.EditTextPassword);
            buttonLogin = FindViewById<Button>(Resource.Id.ButtonLogin);

            buttonLogin.Click += ButtonLogin_Click;

            editTextUsername.Text = "support@appbakkers.nl";
            editTextPassword.Text = "password";
        }

        private void ButtonLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                Auth.Login(editTextUsername.Text, editTextPassword.Text);
            }
            catch (Exception exception)
            {

            }
        }
    }
}