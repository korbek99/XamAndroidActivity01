using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace AppAndroid01
{
    [Activity(Label = "AppAndroid01", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.myButton);
            button.Click += Send;

        }

        private void Send(object sender, EventArgs e)
        {
           var EtNombre =  FindViewById<EditText>(Resource.Id.MainETNombre);
           var nombre = EtNombre.Text;
            Intent intent = new Intent(this,typeof(DataActivity));
            intent.PutExtra("nombre", nombre);
            StartActivity(intent);
           // throw new NotImplementedException();
        }
    }
}

