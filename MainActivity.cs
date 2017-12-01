using Android.App;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);


        }
    }
}

