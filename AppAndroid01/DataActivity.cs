using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppAndroid01
{
    [Activity(Label = "DataActivity")]
    public class DataActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Data);

            var TVNombre = FindViewById<TextView>(Resource.Id.DataTVNombre);

            TVNombre.Text = Intent.GetStringExtra("nombre");


            // Create your application here
        }
    }
}