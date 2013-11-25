using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Content.PM;

namespace TermProject
{
	[Activity(Label = "MainActivity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
		private Button[] _board;
		private bool _playerStart;
		private bool _yourTurn;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.MainLayout);
			_playerStart = Intent.GetBooleanExtra("PlayerStart", true);
			_yourTurn = _playerStart;

            _board = new Button[]
            {
                FindViewById<Button> (Resource.Id.button1), FindViewById<Button> (Resource.Id.button2),
                FindViewById<Button> (Resource.Id.button3), FindViewById<Button> (Resource.Id.button4),
                FindViewById<Button> (Resource.Id.button5), FindViewById<Button> (Resource.Id.button6),
                FindViewById<Button> (Resource.Id.button7), FindViewById<Button> (Resource.Id.button8),
                FindViewById<Button> (Resource.Id.button9), FindViewById<Button> (Resource.Id.button10),
                FindViewById<Button> (Resource.Id.button11), FindViewById<Button> (Resource.Id.button12),
                FindViewById<Button> (Resource.Id.button13), FindViewById<Button> (Resource.Id.button14),
                FindViewById<Button> (Resource.Id.button15), FindViewById<Button> (Resource.Id.button16),
                FindViewById<Button> (Resource.Id.button17), FindViewById<Button> (Resource.Id.button18),
                FindViewById<Button> (Resource.Id.button19), FindViewById<Button> (Resource.Id.button20),
                FindViewById<Button> (Resource.Id.button21), FindViewById<Button> (Resource.Id.button22),
                FindViewById<Button> (Resource.Id.button23), FindViewById<Button> (Resource.Id.button24),
                FindViewById<Button> (Resource.Id.button25), FindViewById<Button> (Resource.Id.button26),
                FindViewById<Button> (Resource.Id.button27), FindViewById<Button> (Resource.Id.button28),
                FindViewById<Button> (Resource.Id.button29), FindViewById<Button> (Resource.Id.button30),
                FindViewById<Button> (Resource.Id.button31), FindViewById<Button> (Resource.Id.button32),
                FindViewById<Button> (Resource.Id.button33), FindViewById<Button> (Resource.Id.button34),
                FindViewById<Button> (Resource.Id.button35), FindViewById<Button> (Resource.Id.button36),
                FindViewById<Button> (Resource.Id.button37), FindViewById<Button> (Resource.Id.button38),
                FindViewById<Button> (Resource.Id.button39), FindViewById<Button> (Resource.Id.button40),
                FindViewById<Button> (Resource.Id.button41), FindViewById<Button> (Resource.Id.button42),
                FindViewById<Button> (Resource.Id.button43), FindViewById<Button> (Resource.Id.button44),
                FindViewById<Button> (Resource.Id.button45), FindViewById<Button> (Resource.Id.button46),
                FindViewById<Button> (Resource.Id.button47), FindViewById<Button> (Resource.Id.button48),
                FindViewById<Button> (Resource.Id.button49),
            };

            foreach (var button in _board)
            {
                button.Click += ButtonClick;
                button.SetTextColor(Color.GhostWhite);
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {

        }
    }
}


