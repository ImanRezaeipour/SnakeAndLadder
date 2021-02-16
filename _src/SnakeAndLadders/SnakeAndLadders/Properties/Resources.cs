//
// Decompiled with: Decompiler.NET, Version=2.0.0.19973, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.19973
// Decompilation Started at: 1/28/2009 1:05:34 AM
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace SnakeAndLadders.Properties
{
	
	#region Namespace Import Declarations
	
	using System.CodeDom.Compiler;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Drawing;
	using System.Globalization;
	using System;
	using System.Reflection;
	using System.Resources;
	using System.Runtime.CompilerServices;
	
	#endregion
	
	[DebuggerNonUserCodeAttribute()]
	[CompilerGeneratedAttribute()]
	[GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	internal class Resources
	{
		#region Fields
		private static CultureInfo resourceCulture;
		private static ResourceManager resourceMan;
		#endregion
		
		#region Constructors
		
		internal Resources ()
		{
		}
		
		#endregion
		
		#region Properties
		
		internal static Bitmap arrow
		{
			get
			{
				return ((Bitmap) Resources.ResourceManager.GetObject ("arrow", Resources.resourceCulture));
			}
		}
		
		
		internal static Bitmap board
		{
			get
			{
				return ((Bitmap) Resources.ResourceManager.GetObject ("board", Resources.resourceCulture));
			}
		}
		
		
		[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}
		
		
		internal static Bitmap NewGame
		{
			get
			{
				return ((Bitmap) Resources.ResourceManager.GetObject ("NewGame", Resources.resourceCulture));
			}
		}
		
		
		[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				System.Resources.ResourceManager resourceManager1;
				if (object.ReferenceEquals (Resources.resourceMan, null))
				{
					resourceManager1 = new System.Resources.ResourceManager ("SnakeAndLadders.Properties.Resources", typeof (Resources).Assembly);
					Resources.resourceMan = resourceManager1;
				}
				return Resources.resourceMan;
			}
		}
		
		
		internal static Bitmap RestartGame
		{
			get
			{
				return ((Bitmap) Resources.ResourceManager.GetObject ("RestartGame", Resources.resourceCulture));
			}
		}
		
		
		internal static Bitmap SmalBeads
		{
			get
			{
				return ((Bitmap) Resources.ResourceManager.GetObject ("SmalBeads", Resources.resourceCulture));
			}
		}
		
		
		internal static Bitmap Speaker
		{
			get
			{
				return ((Bitmap) Resources.ResourceManager.GetObject ("Speaker", Resources.resourceCulture));
			}
		}
		
		#endregion
	}
	
}

