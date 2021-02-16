//
// Decompiled with: Decompiler.NET, Version=2.0.0.19973, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.19973
// Decompilation Started at: 1/28/2009 1:05:34 AM
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace SnakeAndLadders
{
	
	#region Namespace Import Declarations
	
	using System;
	
	#endregion
	
	internal class Game
	{
		#region Fields
		private int[] plocation;
		private bool[] statusWinner;
		#endregion
		
		#region Constructors
		
		public Game ()
		{
			this.statusWinner = new bool[4];
			this.plocation = new int[4];
			this.statusWinner[0] = false;
			this.statusWinner[1] = false;
			this.statusWinner[2] = false;
			this.statusWinner[3] = false;
			this.plocation[0] = 1;
			this.plocation[1] = 1;
			this.plocation[2] = 1;
			this.plocation[3] = 1;
		}
		
		#endregion
		
		#region Methods
		
		public int GetLocation (int playerNo)
		{
			return this.plocation[playerNo];
		}
		
		public bool IsLarggerThan100 (int randomnum, int PlayerNo)
		{
			if ((this.plocation[PlayerNo] + randomnum) > 100)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		public bool IsWinner (int playerNo)
		{
			return this.statusWinner[playerNo];
		}
		
		public void Play (GameBeads gameBeads, int randomnum, int playerNo, bool GoForward)
		{
			int i3;
			int i4;
			int i1 = 111;
			int i2 = 544;
			if (((this.plocation[playerNo] + randomnum) > 100) && GoForward)
			{
				randomnum = 0;
			}
			if (GoForward)
			{
				this.plocation[playerNo] += randomnum;
			}
			else
			{
				this.plocation[playerNo] -= randomnum;
			}
			if ((this.plocation[playerNo] % 10) == 0)
			{
				if (((this.plocation[playerNo] / 10) % 2) == 0)
				{
					i3 = i1;
					i4 = ((int) (i2 - (((this.plocation[playerNo] / 10) - 1) * 56)));
				}
				else
				{
					i3 = ((int) ((((this.plocation[playerNo] % 10) + 9) * 56) + i1));
					i4 = ((int) (i2 - (((this.plocation[playerNo] - 1) / 10) * 56)));
				}
			}
			else if (((this.plocation[playerNo] / 10) % 2) == 0)
			{
				i3 = ((int) ((((this.plocation[playerNo] % 10) - 1) * 56) + i1));
				i4 = ((int) (i2 - ((this.plocation[playerNo] / 10) * 56)));
			}
			else
			{
				i3 = ((int) (((10 - (this.plocation[playerNo] % 10)) * 56) + i1));
				i4 = ((int) (i2 - ((this.plocation[playerNo] / 10) * 56)));
			}
			gameBeads.SetLocation (i3, i4);
			if (this.plocation[playerNo] != 100)
			{
				return;
			}
			this.statusWinner[playerNo] = true;
		}
		
		public void Restart ()
		{
			this.statusWinner[0] = false;
			this.statusWinner[1] = false;
			this.statusWinner[2] = false;
			this.statusWinner[3] = false;
			this.plocation[0] = 1;
			this.plocation[1] = 1;
			this.plocation[2] = 1;
			this.plocation[3] = 1;
		}
		
		#endregion
	}
	
}

