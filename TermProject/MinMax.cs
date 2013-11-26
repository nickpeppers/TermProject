using System;
using Android.Widget;

namespace TermProject
{
    public class MinMax
    {
			//an array of buttons
			static GameButton[][] buttons;
	
			//sending in the color of the player who wants to make the next move
		private int makeMove(GameButton[][] b, char color)
		{
			//updating the gameboard
			buttons = b;

			//getting the opposite color
			char colorSwitched;
			if(color == 'w')
				colorSwitched = 'b';
			else 
				colorSwitched = 'w';

			//getting a list of legal moves
			GameButton[][] moves = legalMoves(colorSwitched);

			//making an array of moves for each move in the above set
			//and finding the min value of each set
			for(int i = 0; i < 7; i++)
				for(int j = 0; j<7; j++)
					if(moves[i][j] != null)
					{
						//adds the button temporarily
						buttons[i][j] = moves[i][j];
						//makes a new set of legal moves based on that last move and switches color
						GameButton[][] temp = legalMoves(color);
						//finds the minimum score
						moves[i][j].score = moveScore(minMove(temp));
						//removes the move
						buttons[i][j] = null;
					}

			//after all of the mins are found, find the max among them and return that move
			GameButton move = maxMove(moves);
			int arrayIndex = move.x + move.y*7;
			return arrayIndex;
		}

			//takes in a button array and finds the one with the max score and returns it
		private GameButton maxMove(GameButton[][] b)
		{
			GameButton temp = b[0][0];;
			for(int i = 0; i < 7; i++)
				for(int j = 0; j<7; j++)
					if(b[i][j].score > temp.score)
						temp = b[i][j];
			return temp;
		}

		private GameButton minMove(GameButton[][] b)
		{
			GameButton temp = b[0][0];
			for(int i = 0; i < 7; i++)
				for(int j = 0; j<7; j++)
					if(moveScore(b[i][j]) < moveScore(temp))
						temp = b[i][j];
			return temp;
		}

		private GameButton[][] legalMoves(char color)
		{
			//making a place to store the moves
			GameButton[][] moves = new GameButton[7][7];
			int count = 0;
			//check each location to see if it is a move
			for(int i = 0; i < 7; i++){
				for(int j = 0; j < 7; j++)
				{
					//if there is a button of the same color, you can have moves around it: left, upperLeft, uppper, upperRight, right,
					//lowerRight, lower, lowerLeft
					if(buttons[i][j].c == color)
					{
						//left
						if(i - 1 >= 0 && j >= 0)
						{
							moves[i-1][j] = buttons[i-1][j];
							count++;
						}
						//upperLeft
						if(i - 1 >= 0 && j - 1 >= 0)
						{
							moves[i-1][j-1] = buttons[i-1][j-1];
							count++;
						}
						//upper
						if(i >= 0 && j - 1 >= 0)
						{
							moves[i][j-1] = buttons[i][j-1];
							count++;
						}
						//upperRight
						if(i + 1 >= 0 && j - 1 >= 0)
						{
							moves[i+1][j-1] = buttons[i+1][j-1];
							count++;
						}
						//right
						if(i + 1 >= 0 && j >= 0)
						{
							moves[i+1][j] = buttons[i+1][j];
							count++;
						}
						//lowerRight
						if(i + 1 >= 0 && j + 1 >= 0)
						{
							moves[i+1][j+1] = buttons[i+1][j+1];
							count++;
						}
						//lower
						if(i >= 0 && j + 1 >= 0)
						{
							moves[i][j+1] = buttons[i][j+1];
							count++;
						}
						//lowerLeft
						if(i - 1 >= 0 && j + 1 >= 0)
						{
							if(moves[i-1][j+1] != null)
							{
								moves[i-1][j+1] = buttons[i-1][j+1];
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
		private	int moveScore(GameButton move)
		{
				//starts off at one because the move made counts as 1
				int score = 1;
				char color = move.c;
				for(int i = 0; i < 7; i++)
					for(int j = 0; j < 7; j++)
						if(buttons[i][j].c == color)
							score++;
				return score;
        }
    }
}

