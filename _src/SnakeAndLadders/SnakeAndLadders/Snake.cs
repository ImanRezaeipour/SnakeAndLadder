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
	
	internal class Snake
	{
		
		#region Constructors
		
		public Snake ()
		{
		}
		
		#endregion
		
		#region Methods
		
		public int status (int location)
		{
			int i2 = location;
			if (i2 <= 41)
			{
				if (i2 == 29)
				{
					return 23;
				}
				if (i2 == 36)
				{
					return 19;
				}
				if (i2 == 41)
				{
					return 22;
				}
				else
				{
					return 0;
				}
			}
			if (i2 <= 76)
			{
				if (i2 == 70)
				{
					return 16;
				}
				if (i2 == 76)
				{
					return 53;
				}
				else
				{
					return 0;
				}
			}
			if (i2 != 93)
			{
				if (i2 == 97)
				{
					return 22;
				}
				else
				{
					return 0;
				}
			}
			return 19;
		}
		
		#endregion
	}
	
}

