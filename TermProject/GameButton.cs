using System;
using Android.Widget;
using Android.Content;
using Android.Util;


namespace TermProject
{
	public class GameButton : Button
    {
		public char color { get; set; }
		//(x,y) position and move score
		public int x { get; set; }

		public int y { get; set; }

		public int score { get; set; }

		public GameButton(Context context, IAttributeSet attr)
			: base(context, attr)
		{

		}

		public GameButton(Context context, IAttributeSet attr,  char color, int xCoordinate, int yCoordinate)
			: base(context, attr)
        {
			this.color = color;
			x = xCoordinate;
			y = yCoordinate;
			score = 0;
        }
    }
}

