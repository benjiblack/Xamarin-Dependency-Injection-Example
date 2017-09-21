using System;
using Android.Widget;
using Xamarin.Android;
using Plugin.CurrentActivity;
using Android.Views;

[assembly: Xamarin.Forms.Dependency(typeof(dependencyinjection.Droid.DroidCameraController))]
namespace dependencyinjection.Droid
{
    public class DroidCameraController : ICameraController
    {
        public DroidCameraController()
        {
        }

        public byte[] TakePhoto()
        {
            throw new NotImplementedException();
        }

        public string TestText()
        {
			trySomethingNew();

			return "This is the Android implementation.";
        }

		private void trySomethingNew()
		{
			var window = CrossCurrentActivity.Current.Activity;

			TextView tv = new TextView(window);
			tv.Text = "WHOA :)";
			tv.SetTextColor(Android.Graphics.Color.Red);
			tv.TextSize = 40;

			LinearLayout linearLayout = new LinearLayout(window);

			linearLayout.SetPadding(50, 50, 50, 50);
			linearLayout.SetY(20);
			linearLayout.SetGravity(Android.Views.GravityFlags.End);

			linearLayout.AddView(tv);

			Android.App.ActionBar.LayoutParams param = new Android.App.ActionBar.LayoutParams(Android.Views.GravityFlags.Center);

			Android.Views.ViewGroup.LayoutParams coolParams = new Android.Views.ViewGroup.LayoutParams(
				ViewGroup.LayoutParams.MatchParent,
				ViewGroup.LayoutParams.MatchParent);

			window.AddContentView(linearLayout, coolParams);
		}
    }
}
