using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Content.PM;
using Android.Widget;
using Android.Content;

namespace Appbakkers.Authentication.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Button buttonPassport = FindViewById<Button>(Resource.Id.ButtonPassport);

            buttonPassport.Click += (s, e) => {
                var intent = new Intent(this, typeof(PassportActivity));
                StartActivity(intent);
            };

            Button buttonSanctum = FindViewById<Button>(Resource.Id.ButtonSanctum);

            buttonSanctum.Click += (s, e) => {
                var intent = new Intent(this, typeof(SanctumActivity));
                StartActivity(intent);
            };
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}

