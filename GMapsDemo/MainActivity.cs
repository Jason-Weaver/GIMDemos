using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;

namespace GMapsDemo
{
    [Activity(Label = "GMapsDemo", MainLauncher = true)]
    public class MainActivity : Activity, IOnMapReadyCallback
    {
        private GoogleMap _map;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Set up map
            FragmentManager.FindFragmentById<MapFragment>(Resource.Id.mapFragment).GetMapAsync(this);
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            if (googleMap != null)
            {
                _map = googleMap;
            }
        }
    }
}

