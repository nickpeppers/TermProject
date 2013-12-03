using System;
using Android.Widget;
using Android.Content;
using Android.Util;


namespace TermProject
{
	// custom button class that inherits from Android Button
	public class GameButton : Button
    {
		public char color { get; set; }

		public int x { get; set; }

		public int y { get; set; }

		public int score { get; set; }

		// default button constructor
		public GameButton(Context context, IAttributeSet attr)
			: base(context, attr)
		{

		}

		// second constructor for GameButtons extra properties
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

