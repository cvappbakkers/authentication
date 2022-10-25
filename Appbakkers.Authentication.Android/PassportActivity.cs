using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Content.PM;
using Android.Widget;
using System;
using Android.Graphics;

namespace Appbakkers.Authentication.Android
{
    [Activity(Label = "Passport")]
    public class PassportActivity : AppCompatActivity
    {
        EditText editTextUsername;
        EditText editTextPassword;
        Button buttonLogin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ActivityLogin);

            Auth.Init("2", "");

            editTextUsername = FindViewById<EditText>(Resource.Id.EditTextUsername);
            editTextPassword = FindViewById<EditText>(Resource.Id.EditTextPassword);
            buttonLogin = FindViewById<Button>(Resource.Id.ButtonLogin);

            buttonLogin.Click += ButtonLogin_Click;

            editTextUsername.Text = "support@appbakkers.nl";
            editTextPassword.Text = "password";

            buttonLogin.SetBackgroundColor(Auth.Check() ? Color.Green : Color.Red);
        }

        private void ButtonLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                Auth.Login(editTextUsername.Text, editTextPassword.Text);
            }
            catch(Exception exception)
            {

            }
        }
    }
}