using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using TermProject;

namespace TermProject
{
	[Activity (Label = "Term Project", LaunchMode = LaunchMode.SingleInstance, ScreenOrientation = ScreenOrientation.Portrait, MainLauncher = true)]
	public class FirstActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.StartLayout);

			Button playerStartButton = FindViewById<Button> (Resource.Id.PlayerStartButton);
			Button computerStartButton = FindViewById<Button> (Resource.Id.ComputerStartButon);

			// adds extra to activity to determine the player starts first
			playerStartButton.Click += (sender, e) => 
			{
				var mainActivity = new Intent (this, typeof(MainActivity));
				mainActivity.PutExtra("PlayerStart", true);
				StartActivity(mainActivity);
			};

			// adds extra to activity to determine the computer starts first
			computerStartButton.Click += (sender, e) => 
			{
				var mainActivity = new Intent (this, typeof(MainActivity));
				mainActivity.PutExtra("PlayerStart", false);
				StartActivity(mainActivity);
			};
		}
	}
}


