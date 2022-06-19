using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace MinesweeperMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btnStart = FindViewById<Button>(Resource.Id.btnStart);
            var btnSettings = FindViewById<Button>(Resource.Id.btnSettings);
            var btnExit = FindViewById<Button>(Resource.Id.btnSettings);

            btnStart.Click += (s, arg) =>
            {
                PopupMenu menu = new PopupMenu(this, btnStart);
                menu.Inflate(Resource.Menu.difficulty_menu);
                menu.Show();

                menu.MenuItemClick += (s1, arg1) =>
                {
                    // Start easy game
                    StartActivity(typeof(GameActivity));
                };
                menu.MenuItemClick += (s2, arg2) =>
                {
                    // Start medium difficulty game
                    StartActivity(typeof(GameActivity));
                };
                menu.MenuItemClick += (s3, arg3) =>
                {
                    // Start hard game
                    StartActivity(typeof(GameActivity));
                };
            };
             
            btnSettings.Click += delegate
            {
                StartActivity(typeof(SettingsActivity));
            };
            btnExit.Click += delegate
            {
                // Will exit Game
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}