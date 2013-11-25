using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using TermProject;

namespace TicTacToe
{
	[Activity (Label = "Term Project", LaunchMode = LaunchMode.SingleInstance, ScreenOrientation = ScreenOrientation.Portrait, MainLauncher = true)]
	public class StartActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.StartLayout);

			Button playerStartButton = FindViewById<Button> (Resource.Id.PlayerStartButton);
			Button computerStartButton = FindViewById<Button> (Resource.Id.ComputerStartButon);

			playerStartButton.Click += (sender, e) => 
			{
				var mainActivity = new Intent (this, typeof(MainActivity));
				mainActivity.PutExtra("PlayerStart", true);
				StartActivity(mainActivity);
			};

			computerStartButton.Click += (sender, e) => 
			{
				var mainActivity = new Intent (this, typeof(MainActivity));
				mainActivity.PutExtra("PlayerStart", false);
				StartActivity(mainActivity);
			};
		}
	}
}


