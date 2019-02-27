using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Locations;
using Android.Gms.Maps;

using System;

namespace OneWay
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

            TextView Latitude = FindViewById<TextView>(Resource.Id.LatitudeNum);
            TextView Longtitude = FindViewById<TextView>(Resource.Id.LongtitudeNum);
            TextView Altitude = FindViewById<TextView>(Resource.Id.AltitudeNum);
            Button GetLocation = FindViewById<Button>(Resource.Id.GetLocation);
           
        

        }
    }
}