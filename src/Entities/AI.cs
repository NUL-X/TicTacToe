using static TicTacToe.Entities.Structures;
using System;
using TicTacToe.Forms;

namespace TicTacToe.Entities
{

	public class GameAI
	{
		
		private MoveType _moveTypeCpu;
		private MoveType _moveTypePlayer;
		private AIDifficulty _difficulty;
		Main _gameForm;

		#region�Constructor 

		public GameAI(Main objForm)
		{
		
			//_____________________________________________________________________________________________
			//
			// Gets main form reference, who is CPU, who is player and
			// difficulty
			//_____________________________________________________________________________________________

			_gameForm=objForm;
			_moveTypeCpu=_gameForm._moveTypeCpu;		// created these 3 fields in Main.cs
			_moveTypePlayer=_gameForm._MoveTypePlayer;
			_difficulty=_gameForm._difficulty;			// still need to update difficulty in Main.cs

		}


		#endregion

		#region�Game (1 player) 

		public void MakeComputerMove()
		{

			//_____________________________________________________________________________________________
			//
			// CPU plays
			//_____________________________________________________________________________________________

			bool wNothing=false;

			//_____________________________________________________________________________________________
			//
			// Return if it is not CPU turn
			//_____________________________________________________________________________________________

			if (_gameForm.wTurn==_moveTypePlayer)
				return;

			//_____________________________________________________________________________________________
			//
			// Routine to check if it is possible to win the game
			// Return if a move was made
			//_____________________________________________________________________________________________

			PlayWinner(false,ref wNothing);

			if (_gameForm.wTurn==_moveTypePlayer)
				return;

			//_____________________________________________________________________________________________
			//
			// Routine to check if there is a move that prevents the player to win
			// Return if a move was made
			//_____________________________________________________________________________________________

			PlayDefensive();

			if (_gameForm.wTurn==_moveTypePlayer)
				return;

			//_____________________________________________________________________________________________
			//
			// Routine to make and avoid "traps"
			//_____________________________________________________________________________________________

			PlayOffensive();

		}
	
		private void PlayWinner(bool pJustVerifyMove,ref bool rGoodMove)
		{
			//_____________________________________________________________________________________________
			//
			// Routine to check if it is possible to win the game
			// (sums lines and check totals latter)
			//_____________________________________________________________________________________________

			if (_difficulty==AIDifficulty.Average)
			{
				rGoodMove=true;
				return;
			}

			int wSum1=(int)_gameForm.wBoard[1,1]+(int)_gameForm.wBoard[1,2]+(int)_gameForm.wBoard[1,3];
			int wSum2=(int)_gameForm.wBoard[2,1]+(int)_gameForm.wBoard[2,2]+(int)_gameForm.wBoard[2,3];
			int wSum3=(int)_gameForm.wBoard[3,1]+(int)_gameForm.wBoard[3,2]+(int)_gameForm.wBoard[3,3];

			int wSum4=(int)_gameForm.wBoard[1,1]+(int)_gameForm.wBoard[2,1]+(int)_gameForm.wBoard[3,1];
			int wSum5=(int)_gameForm.wBoard[1,2]+(int)_gameForm.wBoard[2,2]+(int)_gameForm.wBoard[3,2];
			int wSum6=(int)_gameForm.wBoard[1,3]+(int)_gameForm.wBoard[2,3]+(int)_gameForm.wBoard[3,3];

			int wSum7=(int)_gameForm.wBoard[1,1]+(int)_gameForm.wBoard[2,2]+(int)_gameForm.wBoard[3,3];
			int wSum8=(int)_gameForm.wBoard[3,1]+(int)_gameForm.wBoard[2,2]+(int)_gameForm.wBoard[1,3];

			//_____________________________________________________________________________________________
			//
			// Calculates sum that indicates a good move for CPU 
			//_____________________________________________________________________________________________

			int wCPUSum=0;

			if (_moveTypeCpu==MoveType.Cross)
				wCPUSum=20;
			else
				wCPUSum=2;

			//_____________________________________________________________________________________________
			//
			// If sum checks, plays in the available position to win the game
			//_____________________________________________________________________________________________

			if (wSum1==wCPUSum)
			{
				if (_gameForm.wBoard[1,1]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(1,1);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[1,2]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(1,2);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[1,3]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(1,3);
					rGoodMove=true;
					return;
				}
			}

			if (wSum2==wCPUSum)
			{
				if (_gameForm.wBoard[2,1]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(2,1);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[2,2]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(2,2);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[2,3]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(2,3);
					rGoodMove=true;
					return;
				}
			}

			if (wSum3==wCPUSum)
			{
				if (_gameForm.wBoard[3,1]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(3,1);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[3,2]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(3,2);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[3,3]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(3,3);
					rGoodMove=true;
					return;
				}
			}
			
			if (wSum4==wCPUSum)
			{
				if (_gameForm.wBoard[1,1]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(1,1);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[2,1]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(2,1);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[3,1]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(3,1);
					rGoodMove=true;
					return;
				}
			}

			if (wSum5==wCPUSum)
			{
				if (_gameForm.wBoard[1,2]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(1,2);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[2,2]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(2,2);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[3,2]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(3,2);
					rGoodMove=true;
					return;
				}
			}

			if (wSum6==wCPUSum)
			{
				if (_gameForm.wBoard[1,3]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(1,3);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[2,3]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(2,3);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[3,3]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(3,3);
					rGoodMove=true;
					return;
				}
			}

			if (wSum7==wCPUSum)
			{
				if (_gameForm.wBoard[1,1]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(1,1);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[2,2]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(2,2);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[3,3]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(3,3);
					rGoodMove=true;
					return;
				}
			}

			if (wSum8==wCPUSum)
			{
				if (_gameForm.wBoard[3,1]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(3,1);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[2,2]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(2,2);
					rGoodMove=true;
					return;
				}
				if (_gameForm.wBoard[1,3]==MoveType.None)
				{
					if (pJustVerifyMove==false)
						_gameForm.MakeMove(1,3);
					rGoodMove=true;
					return;
				}
			}

		}

		private void PlayDefensive()
		{
			//_____________________________________________________________________________________________
			//
			// Routine to check if there is a move that prevents the player to win
			// (sum lines and check totals latter)
			//_____________________________________________________________________________________________

			//_____________________________________________________________________________________________
			//
			// In easy and average difficulty sometimes it doesn�t make a defensive move
			//_____________________________________________________________________________________________

			if (_difficulty==AIDifficulty.Average)		
			{
				System.Threading.Thread.Sleep(15);
				System.Random objRandom=new Random();
				int rnd=objRandom.Next(1,6);
				if (rnd==3)
					return;
			}

			if (_difficulty==AIDifficulty.Easy)		
			{
				System.Threading.Thread.Sleep(15);
				System.Random objRandom=new Random();
				int rnd=objRandom.Next(1,3);
				if (rnd==1)
					return;
			}

			//_____________________________________________________________________________________________
			//
			// Sums lines and check totals latter
			//_____________________________________________________________________________________________
			
			int wSum1=(int)_gameForm.wBoard[1,1]+(int)_gameForm.wBoard[1,2]+(int)_gameForm.wBoard[1,3];
			int wSum2=(int)_gameForm.wBoard[2,1]+(int)_gameForm.wBoard[2,2]+(int)_gameForm.wBoard[2,3];
			int wSum3=(int)_gameForm.wBoard[3,1]+(int)_gameForm.wBoard[3,2]+(int)_gameForm.wBoard[3,3];

			int wSum4=(int)_gameForm.wBoard[1,1]+(int)_gameForm.wBoard[2,1]+(int)_gameForm.wBoard[3,1];
			int wSum5=(int)_gameForm.wBoard[1,2]+(int)_gameForm.wBoard[2,2]+(int)_gameForm.wBoard[3,2];
			int wSum6=(int)_gameForm.wBoard[1,3]+(int)_gameForm.wBoard[2,3]+(int)_gameForm.wBoard[3,3];

			int wSum7=(int)_gameForm.wBoard[1,1]+(int)_gameForm.wBoard[2,2]+(int)_gameForm.wBoard[3,3];
			int wSum8=(int)_gameForm.wBoard[3,1]+(int)_gameForm.wBoard[2,2]+(int)_gameForm.wBoard[1,3];

			//_____________________________________________________________________________________________
			//
			// Calculates sum that indicates two piecies in a row for human player
			//_____________________________________________________________________________________________

			int wPlayerSum=0;

			if (_moveTypePlayer==MoveType.Cross)
				wPlayerSum=20;
			else
				wPlayerSum=2;

			//_____________________________________________________________________________________________
			//
			// If sum checks, plays in the available position preventing player to win
			//_____________________________________________________________________________________________

			if (wSum1==wPlayerSum)
			{
				if (_gameForm.wBoard[1,1]==MoveType.None) {
					_gameForm.MakeMove(1,1);return;}
				if (_gameForm.wBoard[1,2]==MoveType.None) {
					_gameForm.MakeMove(1,2);return;}
				if (_gameForm.wBoard[1,3]==MoveType.None) {
					_gameForm.MakeMove(1,3);return;}
			}

			if (wSum2==wPlayerSum)
			{
				if (_gameForm.wBoard[2,1]==MoveType.None) {
					_gameForm.MakeMove(2,1);return;}
				if (_gameForm.wBoard[2,2]==MoveType.None) {
					_gameForm.MakeMove(2,2);return;}
				if (_gameForm.wBoard[2,3]==MoveType.None) {
					_gameForm.MakeMove(2,3);return;}
			}

			if (wSum3==wPlayerSum)
			{
				if (_gameForm.wBoard[3,1]==MoveType.None) {
					_gameForm.MakeMove(3,1);return;}
				if (_gameForm.wBoard[3,2]==MoveType.None) {
					_gameForm.MakeMove(3,2);return;}
				if (_gameForm.wBoard[3,3]==MoveType.None) {
					_gameForm.MakeMove(3,3);return;}
			}
			
			if (wSum4==wPlayerSum)
			{
				if (_gameForm.wBoard[1,1]==MoveType.None) {
					_gameForm.MakeMove(1,1);return;}
				if (_gameForm.wBoard[2,1]==MoveType.None) {
					_gameForm.MakeMove(2,1);return;}
				if (_gameForm.wBoard[3,1]==MoveType.None) {
					_gameForm.MakeMove(3,1);return;}
			}

			if (wSum5==wPlayerSum)
			{
				if (_gameForm.wBoard[1,2]==MoveType.None) {
					_gameForm.MakeMove(1,2);return;}
				if (_gameForm.wBoard[2,2]==MoveType.None) {
					_gameForm.MakeMove(2,2);return;}
				if (_gameForm.wBoard[3,2]==MoveType.None) {
					_gameForm.MakeMove(3,2);return;}
			}

			if (wSum6==wPlayerSum)
			{
				if (_gameForm.wBoard[1,3]==MoveType.None) {
					_gameForm.MakeMove(1,3);return;}
				if (_gameForm.wBoard[2,3]==MoveType.None) {
					_gameForm.MakeMove(2,3);return;}
				if (_gameForm.wBoard[3,3]==MoveType.None) {
					_gameForm.MakeMove(3,3);return;}
			}

			if (wSum7==wPlayerSum)
			{
				if (_gameForm.wBoard[1,1]==MoveType.None) {
					_gameForm.MakeMove(1,1);return;}
				if (_gameForm.wBoard[2,2]==MoveType.None) {
					_gameForm.MakeMove(2,2);return;}
				if (_gameForm.wBoard[3,3]==MoveType.None) {
					_gameForm.MakeMove(3,3);return;}
			}

			if (wSum8==wPlayerSum)
			{
				if (_gameForm.wBoard[3,1]==MoveType.None) {
					_gameForm.MakeMove(3,1);return;}
				if (_gameForm.wBoard[2,2]==MoveType.None) {
					_gameForm.MakeMove(2,2);return;}
				if (_gameForm.wBoard[1,3]==MoveType.None) {
					_gameForm.MakeMove(1,3);return;}
			}
			
		}

		private void PlayOffensive()
		{
			//_____________________________________________________________________________________________
			//
			// Routine to make and avoid "traps"
			//_____________________________________________________________________________________________

			//_____________________________________________________________________________________________
			//
			// This routine works as follow:
			//
			//		- If player is O try in the middle
			//		- If player is X try playing in the inverse diagonal of the player
			//		  in case there is a player�s piece on the corner
			//
			//		- If there is a player�s piece in a corner 
			//		  try next to player�s piece (HARD difficulty)
			//			- Try smart moves to avoid "traps" (HARD difficulty)
			//
			//		- Try on the corner
			//		  (checks in a random order if there is an available position)
			//		- Try on the sides
			//		- Try in the middle
			//
			//_____________________________________________________________________________________________
		
			bool wGoodMove=false;

			if (_difficulty==AIDifficulty.Hard)
			{
				if (_moveTypePlayer==MoveType.Cross)
				{
				
					//_____________________________________________________________________________________________
					//
					//	If player is X try playing in the inverse diagonal of the player
					//	in case there is a player�s piece on the corner
					//_____________________________________________________________________________________________
					
					if ((_gameForm.wBoard[1,1]==MoveType.None) && (_gameForm.wBoard[3,3]==_moveTypePlayer))
					{
						_gameForm.MakeMove(1,1);
						return;
					}
									
					if ((_gameForm.wBoard[1,3]==MoveType.None) && (_gameForm.wBoard[3,1]==_moveTypePlayer))
					{
						_gameForm.MakeMove(1,3);
						return;
					}
					
					if ((_gameForm.wBoard[3,1]==MoveType.None) && (_gameForm.wBoard[1,3]==_moveTypePlayer))
					{
						_gameForm.MakeMove(3,1);
						return;
					}
					
					if ((_gameForm.wBoard[3,3]==MoveType.None) && (_gameForm.wBoard[1,1]==_moveTypePlayer))
					{
						_gameForm.MakeMove(3,3);
						return;
					}
				}
				else
				{
					//_____________________________________________________________________________________________
					//
					// Try in the middle
					//_____________________________________________________________________________________________

					if (_gameForm.wBoard[2,2]==MoveType.None)
					{
						_gameForm.MakeMove(2,2);
						return;
					}
				}
			}
			
			//_____________________________________________________________________________________________
			//
			// If there is a player�s piece in a corner 
			// try next to player�s piece (HARD difficulty)
			// Try smart moves to avoid "traps" (HARD difficulty)
			//_____________________________________________________________________________________________

			if (_difficulty==AIDifficulty.Hard)
			{
				
				//_____________________________________________________________________________________________
				// 
				// Moves:		 |M|O		 | |O 
				//				-----		-----
				//				 |X|		 |X|  
				//				-----		-----
				//				O| | 		O|M|
				//
				//
				//				O|M|		O| |   
				//				-----		-----
				//				 |X|		 |X| 
				//				-----		-----
				//				 | |O		 |M|O
				//
				//_____________________________________________________________________________________________

				if ((_gameForm.wBoard[1,2]==MoveType.None) && ((_gameForm.wBoard[1,3]==_moveTypePlayer) && (_gameForm.wBoard[3,1]==_moveTypePlayer)))
				{
					_gameForm.wBoard[1,2]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[1,2]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(1,2);
						return;
					}
				}

				if ((_gameForm.wBoard[3,2]==MoveType.None) && ((_gameForm.wBoard[1,3]==_moveTypePlayer) && (_gameForm.wBoard[3,1]==_moveTypePlayer)))
				{
					_gameForm.wBoard[3,2]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[3,2]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(3,2);
						return;
					}
				}

				if ((_gameForm.wBoard[1,2]==MoveType.None) && ((_gameForm.wBoard[1,1]==_moveTypePlayer) && (_gameForm.wBoard[3,3]==_moveTypePlayer)))
				{
					_gameForm.wBoard[1,2]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[1,2]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(1,2);
						return;
					}
				}

				if ((_gameForm.wBoard[3,2]==MoveType.None) && ((_gameForm.wBoard[1,1]==_moveTypePlayer) && (_gameForm.wBoard[3,3]==_moveTypePlayer)))
				{
					_gameForm.wBoard[3,2]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[3,2]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(3,2);
						return;
					}
				}
				

				//_____________________________________________________________________________________________
				// 
				// Moves:		 |M|		O| | 
				//				-----		-----
				//				O|X|		M|X|  
				//				-----		-----
				//				 | |O		 |O| 
				//
				//
				//				 | |O		 | |  
				//				-----		-----
				//				 |X|M		 |X|O 
				//				-----		-----
				//				 |O|		O|M| 
				//
				//_____________________________________________________________________________________________

				if ((_gameForm.wBoard[1,2]==MoveType.None) && ((_gameForm.wBoard[2,1]==_moveTypePlayer) && (_gameForm.wBoard[3,3]==_moveTypePlayer)))
				{
					_gameForm.wBoard[1,2]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[1,2]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(1,2);
						return;
					}
				}

				if ((_gameForm.wBoard[2,1]==MoveType.None) && ((_gameForm.wBoard[1,1]==_moveTypePlayer) && (_gameForm.wBoard[3,2]==_moveTypePlayer)))
				{
					_gameForm.wBoard[2,1]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[2,1]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(2,1);
						return;
					}
				}

				if ((_gameForm.wBoard[2,3]==MoveType.None) && ((_gameForm.wBoard[1,3]==_moveTypePlayer) && (_gameForm.wBoard[3,2]==_moveTypePlayer)))
				{
					_gameForm.wBoard[2,3]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[2,3]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(2,3);
						return;
					}
				}

				if ((_gameForm.wBoard[3,2]==MoveType.None) && ((_gameForm.wBoard[2,3]==_moveTypePlayer) && (_gameForm.wBoard[3,1]==_moveTypePlayer)))
				{
					_gameForm.wBoard[3,2]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[3,2]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(3,2);
						return;
					}
				}

				//_____________________________________________________________________________________________
				// 
				// Moves:		 |O|		O| | 
				//				-----		-----
				//				 |X|M		M|X|  
				//				-----		-----
				//				O| | 		 |O| 
				//_____________________________________________________________________________________________

				if ((_gameForm.wBoard[2,3]==MoveType.None) && ((_gameForm.wBoard[3,1]==_moveTypePlayer) && (_gameForm.wBoard[1,2]==_moveTypePlayer)))
				{
					_gameForm.wBoard[2,3]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[2,3]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(2,3);
						return;
					}
				}

				if ((_gameForm.wBoard[2,1]==MoveType.None) && ((_gameForm.wBoard[1,1]==_moveTypePlayer) && (_gameForm.wBoard[3,2]==_moveTypePlayer)))
				{
					_gameForm.wBoard[2,1]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[2,1]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(2,1);
						return;
					}
				}

				//_____________________________________________________________________________________________
				// 
				// Moves:		M|O|		 |O|M 
				//				-----		-----
				//				O|X|		 |X|O 
				//				-----		-----
				//				 | | 		 | |
				//
				//
				//				 | |		 | |   
				//				-----		-----
				//				 |X|O		O|X| 
				//				-----		-----
				//				 |O|M		M|O| 
				//
				//_____________________________________________________________________________________________

				if ((_gameForm.wBoard[1,1]==MoveType.None) && ((_gameForm.wBoard[1,2]==_moveTypePlayer) && (_gameForm.wBoard[2,1]==_moveTypePlayer)))
				{
					_gameForm.wBoard[1,1]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[1,1]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(1,1);
						return;
					}
				}

				if ((_gameForm.wBoard[1,3]==MoveType.None) && ((_gameForm.wBoard[1,2]==_moveTypePlayer) && (_gameForm.wBoard[2,3]==_moveTypePlayer)))
				{
					_gameForm.wBoard[1,3]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[1,3]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(1,3);
						return;
					}
				}

				if ((_gameForm.wBoard[3,3]==MoveType.None) && ((_gameForm.wBoard[2,3]==_moveTypePlayer) && (_gameForm.wBoard[3,2]==_moveTypePlayer)))
				{
					_gameForm.wBoard[3,3]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[3,3]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(3,3);
						return;
					}
				}

				if ((_gameForm.wBoard[3,1]==MoveType.None) && ((_gameForm.wBoard[2,1]==_moveTypePlayer) && (_gameForm.wBoard[3,2]==_moveTypePlayer)))
				{
					_gameForm.wBoard[3,1]=_moveTypeCpu;
					PlayWinner(true,ref wGoodMove);
					_gameForm.wBoard[3,1]=MoveType.None;

					if (wGoodMove==true)
					{
						_gameForm.MakeMove(3,1);
						return;
					}
				}

			}

			//_____________________________________________________________________________________________
			//
			//	Try on the corner
			//	(checks in a random order if there is an available position)
			//_____________________________________________________________________________________________

			System.Threading.Thread.Sleep(15);
			System.Random objRandom=new Random();
			int rnd=objRandom.Next(1,5);

			int[] wPosicaoPontaX = new int[5];
			int[] wPosicaoPontaY = new int[5];
		
			if (rnd==1)
			{
				wPosicaoPontaX[1]=1;wPosicaoPontaY[1]=1;
				wPosicaoPontaX[2]=1;wPosicaoPontaY[2]=3;
				wPosicaoPontaX[3]=3;wPosicaoPontaY[3]=1;
				wPosicaoPontaX[4]=3;wPosicaoPontaY[4]=3;
			}
			if (rnd==2)
			{
				
				wPosicaoPontaX[1]=1;wPosicaoPontaY[1]=3;
				wPosicaoPontaX[2]=3;wPosicaoPontaY[2]=1;
				wPosicaoPontaX[3]=3;wPosicaoPontaY[3]=3;
				wPosicaoPontaX[4]=1;wPosicaoPontaY[4]=1;
			}
			if (rnd==3)
			{
			
				wPosicaoPontaX[1]=3;wPosicaoPontaY[1]=1;
				wPosicaoPontaX[2]=3;wPosicaoPontaY[2]=3;
				wPosicaoPontaX[3]=1;wPosicaoPontaY[3]=1;
				wPosicaoPontaX[4]=1;wPosicaoPontaY[4]=3;
			}
			if (rnd==4)
			{
				
				wPosicaoPontaX[1]=3;wPosicaoPontaY[1]=3;
				wPosicaoPontaX[2]=1;wPosicaoPontaY[2]=1;
				wPosicaoPontaX[3]=1;wPosicaoPontaY[3]=3;
				wPosicaoPontaX[4]=3;wPosicaoPontaY[4]=1;
			}
			
			if (_gameForm.wBoard[wPosicaoPontaX[1],wPosicaoPontaY[1]]==MoveType.None)
			{
				_gameForm.MakeMove(wPosicaoPontaX[1],wPosicaoPontaY[1]);
				return;
			}
		
			if (_gameForm.wBoard[wPosicaoPontaX[2],wPosicaoPontaY[2]]==MoveType.None)
			{
				_gameForm.MakeMove(wPosicaoPontaX[2],wPosicaoPontaY[2]);
				return;
			}
		
			if (_gameForm.wBoard[wPosicaoPontaX[3],wPosicaoPontaY[3]]==MoveType.None)
			{
				_gameForm.MakeMove(wPosicaoPontaX[3],wPosicaoPontaY[3]);
				return;
			}
		
			if (_gameForm.wBoard[wPosicaoPontaX[4],wPosicaoPontaY[4]]==MoveType.None)
			{
				_gameForm.MakeMove(wPosicaoPontaX[4],wPosicaoPontaY[4]);
				return;
			}

			//_____________________________________________________________________________________________
			//
			// Try on the sides
			//_____________________________________________________________________________________________

			if (_gameForm.wBoard[1,2]==MoveType.None)
			{
				_gameForm.MakeMove(1,2);
				return;
			}

			if (_gameForm.wBoard[2,1]==MoveType.None)
			{
				_gameForm.MakeMove(2,1);
				return;
			}

			if (_gameForm.wBoard[2,3]==MoveType.None)
			{
				_gameForm.MakeMove(2,3);
				return;
			}

			if (_gameForm.wBoard[3,2]==MoveType.None)
			{
				_gameForm.MakeMove(3,2);
				return;
			}

			//_____________________________________________________________________________________________
			//
			// Try in the middle
			//_____________________________________________________________________________________________

			if (_gameForm.wBoard[2,2]==MoveType.None)
			{
				_gameForm.MakeMove(2,2);
				return;
			}

		}

		#endregion

	}
}