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
	
	internal class RandomPic
	{
		#region Fields
		private static int rand;
		private Random random;
		private bool[] StartMoving;
		#endregion
		
		#region Constructors
		
		public RandomPic ()
		{
			this.StartMoving = new bool[4];
			this.random = new Random ();
			RandomPic.rand = 0;
			this.StartMoving[0] = false;
			this.StartMoving[1] = false;
			this.StartMoving[2] = false;
			this.StartMoving[3] = false;
		}
		
		#endregion
		
		#region Methods
		
		public bool CanStartMoving (int PlayerNumber)
		{
			return this.StartMoving[PlayerNumber];
		}
		
		public int GetRand ()
		{
			return RandomPic.rand;
		}
		
		public string next (int PlayerNumber)
		{
			RandomPic.rand = (this.random.Next (6) + 1);
			this.StartMoving[PlayerNumber] = (this.StartMoving[PlayerNumber] || (RandomPic.rand == 6));
			return ("pic/" + RandomPic.rand.ToString () + ".png");
		}
		
		public void Restart ()
		{
			this.StartMoving[0] = false;
			this.StartMoving[1] = false;
			this.StartMoving[2] = false;
			this.StartMoving[3] = false;
		}
		
		#endregion
	}
	
}

