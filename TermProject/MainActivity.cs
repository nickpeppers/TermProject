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
		private GameButton[] _board;
		private bool _playerStart;
		private bool _yourTurn;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.MainLayout);
			_playerStart = Intent.GetBooleanExtra("PlayerStart", true);
			_yourTurn = _playerStart;

            _board = new GameButton[]
            {
                FindViewById<GameButton> (Resource.Id.button1), FindViewById<GameButton> (Resource.Id.button2),
                FindViewById<GameButton> (Resource.Id.button3), FindViewById<GameButton> (Resource.Id.button4),
                FindViewById<GameButton> (Resource.Id.button5), FindViewById<GameButton> (Resource.Id.button6),
                FindViewById<GameButton> (Resource.Id.button7), FindViewById<GameButton> (Resource.Id.button8),
                FindViewById<GameButton> (Resource.Id.button9), FindViewById<GameButton> (Resource.Id.button10),
                FindViewById<GameButton> (Resource.Id.button11), FindViewById<GameButton> (Resource.Id.button12),
                FindViewById<GameButton> (Resource.Id.button13), FindViewById<GameButton> (Resource.Id.button14),
                FindViewById<GameButton> (Resource.Id.button15), FindViewById<GameButton> (Resource.Id.button16),
                FindViewById<GameButton> (Resource.Id.button17), FindViewById<GameButton> (Resource.Id.button18),
                FindViewById<GameButton> (Resource.Id.button19), FindViewById<GameButton> (Resource.Id.button20),
                FindViewById<GameButton> (Resource.Id.button21), FindViewById<GameButton> (Resource.Id.button22),
                FindViewById<GameButton> (Resource.Id.button23), FindViewById<GameButton> (Resource.Id.button24),
                FindViewById<GameButton> (Resource.Id.button25), FindViewById<GameButton> (Resource.Id.button26),
                FindViewById<GameButton> (Resource.Id.button27), FindViewById<GameButton> (Resource.Id.button28),
                FindViewById<GameButton> (Resource.Id.button29), FindViewById<GameButton> (Resource.Id.button30),
                FindViewById<GameButton> (Resource.Id.button31), FindViewById<GameButton> (Resource.Id.button32),
                FindViewById<GameButton> (Resource.Id.button33), FindViewById<GameButton> (Resource.Id.button34),
                FindViewById<GameButton> (Resource.Id.button35), FindViewById<GameButton> (Resource.Id.button36),
                FindViewById<GameButton> (Resource.Id.button37), FindViewById<GameButton> (Resource.Id.button38),
                FindViewById<GameButton> (Resource.Id.button39), FindViewById<GameButton> (Resource.Id.button40),
                FindViewById<GameButton> (Resource.Id.button41), FindViewById<GameButton> (Resource.Id.button42),
                FindViewById<GameButton> (Resource.Id.button43), FindViewById<GameButton> (Resource.Id.button44),
                FindViewById<GameButton> (Resource.Id.button45), FindViewById<GameButton> (Resource.Id.button46),
                FindViewById<GameButton> (Resource.Id.button47), FindViewById<GameButton> (Resource.Id.button48),
                FindViewById<GameButton> (Resource.Id.button49),
            };

			for (int i = 0; i < _board.Length; i++) 
			{
				_board[i].Click += GameButtonClick;
				_board[i].x = i % 7;
				_board[i].y = (i / 7);
            }

			_board[0].PerformClick();
			_board[6].PerformClick();
			_board[48].PerformClick();
			_board[42].PerformClick();
        }

        private void GameButtonClick(object sender, EventArgs e)
        {
			var button = sender as GameButton;

			if (!_yourTurn)
			{
				button.SetBackgroundColor(Color.Black);
				_yourTurn = !_yourTurn;
			}
			else
			{
				button.SetBackgroundColor(Color.White);
				_yourTurn = !_yourTurn;
			}
        }
    }
}


