using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SharpRegion
{
	public class RegionGen
	{
		#region Variables
		private int arcAngle = 3;
		private int x,
			y,
			width,
			height;
		#endregion
		#region Properties
		public int ArcAngle
		{
			get => arcAngle;
			set => arcAngle = value;
		}
		public int X
		{
			get => x;
			set => x = value;
		}
		public int Y
		{
			get => y;
			set => y = value;
		}
		public int Width
		{
			get => width;
			set => width = value;
		}
		public int Height
		{
			get => height;
			set => height = value;
		}
		#endregion
		#region DllImports
		[DllImport("gdi32")]
		private static extern IntPtr CreateRoundRectRgn(
			int left,
			int top,
			int right,
			int bottom,
			int width,
			int height);
		#endregion
		#region Constructor
		public RegionGen(int x, int y, int width, int height, int arcAngle = 3)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
			this.arcAngle = arcAngle;
		}

		public static RegionGen Create(int x, int y, int width, int height, int arcAngle = 3)
		{
			return new RegionGen(x, y, width, height, arcAngle);
		}
		#endregion
		#region Functions
		public Region CreateRgn()
		{
			return Region.FromHrgn(CreateRoundRectRgn(
				x,
				y,
				width,
				height,
				arcAngle,
				arcAngle));
		}
		#endregion
	}
}
