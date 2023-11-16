using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using System;
using System.Linq;
using EmbedTestOld.AndroidLibrary1;
using EmbedTestOld.ClassLibrary1;

namespace EmbedAssemlyTestOld
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

            var androidClass1 = new AndroidClass1();

            var class1 = new Class1();

            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.Contains("EmbedTest")).ToList();
        }
    }
}