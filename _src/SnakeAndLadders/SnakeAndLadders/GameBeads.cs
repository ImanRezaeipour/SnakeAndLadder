//
// Decompiled with: Decompiler.NET, Version=2.0.0.19973, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.19973
// Decompilation Started at: 1/28/2009 1:05:34 AM
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace SnakeAndLadders
{
	
	#region Namespace Import Declarations
	
	using System.Drawing;
	using System.Drawing.Imaging;
	using System;
	
	#endregion
	
	internal class GameBeads
	{
		#region Fields
		private Bitmap pieceImage;
		private Rectangle targetRectangle;
		#endregion
		
		#region Constructors
		
		public GameBeads (int type, int xLocation, int yLocation)
		{
			this.targetRectangle = new Rectangle (0, 0, 42, 42);
			Bitmap bitmap1 = ((Bitmap) Image.FromFile ("Pic/Bead.png"));
			this.targetRectangle.X = xLocation;
			this.targetRectangle.Y = yLocation;
			this.pieceImage = bitmap1.Clone (new Rectangle (((int) (type * 42)), 0, 42, 42), PixelFormat.DontCare);
		}
		
		#endregion
		
		#region Methods
		
		public void Clone (int width, int height)
		{
			this.targetRectangle = new Rectangle (0, 0, width, height);
		}
		
		public void Draw (Graphics graphicsObject)
		{
			graphicsObject.DrawImage (((Image) this.pieceImage), this.targetRectangle);
		}

        public int GetBeadX(Rectangle targetRectangle)
		{
            return this.targetRectangle.X;
		}
		
		public int GetBeadY ()
		{
			return this.targetRectangle.Y;
		}
		
		public void SetLocation (int xLocation, int yLocation)
		{
			this.targetRectangle.X = xLocation;
			this.targetRectangle.Y = yLocation;
		}
		
		#endregion
	}
	
}

