using System;
using Android.Widget;

namespace TermProject
{
	public class GameButton : Button
    {
		public char c { get; set; }
		//(x,y) position and move score
		public int x { get; set; }

		public int y { get; set; }

		public int score { get; set; }

		public GameButton(char color, int xCoordinate, int yCoordinate)
        {
			c = color;
			x = xCoordinate;
			y = yCoordinate;
			score = 0;
        }
    }
}

