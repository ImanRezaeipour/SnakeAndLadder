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
	
	internal class rtynnv
	{
		
		#region Constructors
		
		public rtynnv ()
		{
		}
		
		#endregion
		
		#region Methods
		
		public int status (int location)
		{
			int i2 = location;
			if (i2 <= 21)
			{
				if (i2 == 8)
				{
					return 19;
				}
				if (i2 == 16)
				{
					return 22;
				}
                if (i2 != 21)
                {
                    return 0;
                }
                else
                {
                    return 42;
                }
			}
			if (i2 <= 47)
			{
				if (i2 == 31)
				{
					return 17;
				}
				if (i2 == 47)
				{
					return 38;
				}
				else
				{
					return 0;
				}
			}
			if (i2 != 71)
			{
				if (i2 == 83)
				{
					return 16;
				}
				else
				{
					return 0;
				}
			}
			return 21;
		}
		
		#endregion
	}
	
}

