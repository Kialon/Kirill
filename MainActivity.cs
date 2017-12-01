using Android.App;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private ViewFlipper _flipper;
        private Button btnPrev, btnNext;
            protected override void OnCreate(Bundle savedInstanceState)
            {
                  base.OnCreate(savedInstanceState);

                  // Set our view from the "main" layout resource
                  SetContentView(Resource.Layout.Main);
            _flipper = FindViewById<ViewFlipper>(Resource.Id.viewFlipper);

            btnNext = FindViewById<Button>(Resource.Id.btnNext);
            btnPrev = FindViewById<Button>(Resource.Id.btnPrev);

            // Use button clicks to cycle through views
            btnNext.Click += (sender, e) => {
                // Use custom animations
                _flipper.SetOutAnimation(this, Resource.Animation.slideout_left);
                _flipper.SetInAnimation(this, Resource.Animation.slidein_right);
                // Use Android built-in animations
                //_flipper.SetInAnimation(this, Android.Resource.Animation.SlideInLeft);      
                //_flipper.SetOutAnimation(this, Android.Resource.Animation.SlideOutRight);
                _flipper.ShowNext();
            };
            btnPrev.Click += (sender, e) => {
                // Use custom animations
                _flipper.SetOutAnimation(this, Resource.Animation.slideout_right);
                _flipper.SetInAnimation(this, Resource.Animation.slidein_left);
                // Use Android built-in animations
                //_flipper.SetInAnimation(this, Android.Resource.Animation.SlideInLeft);
                //_flipper.SetOutAnimation(this, Android.Resource.Animation.SlideOutRight);
                _flipper.ShowPrevious();
            };

        }
    }
}
            
    


