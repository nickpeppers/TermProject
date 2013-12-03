using System;
using Android.Widget;

namespace TermProject
{
	public class MinMax
	{

		public GameButton[,] buttons { get; set; }

		public int makeMove(GameButton[,] b, char color)
		{
			//updating the gameboard
			buttons = b;
			color = 'b';

			GameButton[,] butt = legalMoves('b');
			for(int i = 0; i<7;i++)
				for(int j = 0; j<7;j++)
					if(butt[i,j] != null)
						butt[i,j].score = (moveScore(butt[i,j] , 'b'));
			GameButton temp = maxMove(butt);
			return temp.x + temp.y*7;
		}

		//sending in the color of the player who wants to make the next move
		private int moveScore(GameButton move, char c)
		{
			//starts off at one because the move made counts as 1
			int score = 1;
			char color = c;
			for(int i = 0; i < 7; i++)
				for(int j = 0; j < 7; j++)
					if(buttons[i,j].color == color)
						score++;
			return score;
		}

		//takes in a button array and finds the one with the max score and returns it
		private GameButton maxMove(GameButton[,] b)
		{
			GameButton temp = null;

			for(int i = 0; i < 7; i++)
				for(int j = 0; j<7; j++)
					if (b[i,j] != null)
						temp = b[i,j];

			for (int i = 0; i < 7; i++)
				for (int j = 0; j < 7; j++)
					if (b[i, j] != null)
					{
						if (b[i,j].score > temp.score)
						{
							temp = b[i,j];
						}
					}
			return temp;
		}
				
		private GameButton[,] legalMoves(char color)
		{
			//making a place to store the moves
			GameButton[,] moves = new GameButton[7,7];
			int count = 0;
			//check each location to see if it is a move
			for(int i = 0; i < 7; i++){
				for(int j = 0; j < 7; j++)

				{
					//if there is a button of the same color, you can have moves around it: left, upperLeft, uppper, upperRight, right,
					//lowerRight, lower, lowerLeft
					if(buttons[i,j].color == color)
					{
						//left
						if(i - 1 >= 0 && buttons[i-1,j].color == 'n')
						{
							moves[i-1,j] = buttons[i-1,j];
							count++;
						}
						//upperLeft
						if(i - 1 >= 0 && j - 1 >= 0 && buttons[i-1,j-1].color == 'n')
						{
							moves[i-1,j-1] = buttons[i-1,j-1];
							count++;
						}
						//upper
						if(j - 1 >= 0 && buttons[i,j-1].color == 'n')
						{
							moves[i,j-1] = buttons[i,j-1];
							count++;
						}
						//upperRight
						if(i + 1 < 7 && j - 1 >= 0 && buttons[i+1,j-1].color == 'n')
						{
							moves[i+1,j-1] = buttons[i+1,j-1];
							count++;
						}
						//right
						if(i + 1 < 7 && buttons[i+1,j].color == 'n')
						{
							moves[i+1,j] = buttons[i+1,j];
							count++;
						}
						//lowerRight
						if(i + 1 < 7 && j + 1 < 7 && buttons[i+1,j+1].color == 'n')
						{
							moves[i+1,j+1] = buttons[i+1,j+1];
							count++;
						}
						//lower
						if(j + 1 < 7 && buttons[i,j+1].color == 'n')
						{
							moves[i,j+1] = buttons[i,j+1];
							count++;
						}
						//lowerLeft
						if(i - 1 >= 0 && j + 1 < 7 && buttons[i-1,j+1].color == 'n')
						{
							if(moves[i-1,j+1] != null)
							{
								moves[i-1,j+1] = buttons[i-1,j+1];
								count++;
							}
						}
					}
				}
			}//end for loops
			return moves;
		}

		//takes in a theoretical move and determines the score
		//each button counts as 1
		private int moveScore(GameButton move)
		{
			//starts off at one because the move made counts as 1
			int score = 1;
			char color = move.color;
			for(int i = 0; i < 7; i++)
				for(int j = 0; j < 7; j++)
					if(buttons[i,j].color == color)
						score++;
			return score;
		}
	}
}