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
	using System.Configuration;
	using System.Runtime.CompilerServices;
	using System;
	
	#endregion
	
	[CompilerGeneratedAttribute()]
	[GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		#region Fields
		private static Settings defaultInstance;
		#endregion
		
		#region Constructors
		
		public Settings ()
		{
		}
		
		
		static Settings ()
		{
			Settings.defaultInstance = ((Settings) SettingsBase.Synchronized (((SettingsBase) new Settings ())));
		}
		
		#endregion
		
		#region Properties
		
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}
		
		#endregion
	}
	
}

