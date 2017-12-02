using Android.App;
using Android.Widget;
using Android.OS;

using System.Collections.Generic;
using System.Collections;
using XAMLDemo;

namespace BackendDemo
{
    [Activity(Label = "BackendDemo", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private AzureDataService _dataService;
        private List<Cache> _items;
        private ListView _listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Initialize Azure Mobile Client
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            _dataService = new AzureDataService("@string/azure_mobile_app_url");

            // Need to Initialize _items from Azure DB

            CacheListView adapter = new CacheListView(this, _items);
            _listView.Adapter = adapter;
        }
    }
}

