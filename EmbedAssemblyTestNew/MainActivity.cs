using EmbedTestNew.AndroidLibrary1;
using EmbedTestNew.ClassLibrary1;

namespace EmbedAssemblyTestNew
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var androidClass1 = new AndroidClass1();

            var class1 = new Class1();

            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.Contains("EmbedTest")).ToList();
        }
    }
}