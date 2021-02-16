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
	using System.Windows.Forms;
	
	#endregion
	
	internal abstract class Program
	{
		
		#region Methods
		
		[STAThreadAttribute()]
		private static void Main ()
		{
			Application.EnableVisualStyles ();
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (((Form) new MainBoard ()));
		}
		
		#endregion
	}
	
}

