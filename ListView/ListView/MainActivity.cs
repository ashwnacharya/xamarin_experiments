using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using ListViewLibrary;

namespace ListViewTutorial
{
    [Activity(Label = "ListViewTutorial", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        ListView myListView;
        List<string> list;

        Catalog catalog;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Catalog catalog = new Catalog();


            myListView = FindViewById<ListView>(Resource.Id.myListView);
            CategoryListViewAdapter listAdapter = new CategoryListViewAdapter(this, catalog.GetCategories());
            myListView.Adapter = listAdapter;

            myListView.ItemClick += myListView_ItemClick;
          
        }

        void myListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var activity = new Intent(this, typeof(BrowseCategoryActivity));
            activity.PutExtra("index", e.Position);
            StartActivity(activity);

        }
    }
}

