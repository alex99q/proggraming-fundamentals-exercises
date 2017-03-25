using System;

namespace Rectangle_Position
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var ok = new Rectagle();
			ok.Top = 4;
			ok.Left = -3;
			ok.Width = 4;
			ok.Top = 6;
		}
	}

	public class Rectagle
	{
		public double Top { get; set; }

		public double Left { get; set; }

		public double Width { get; set; }

		public double Height { get; set; }

		public double Right { get; set;}

		public double Bottom { get; set; }

		public void GetSecondPoint()
		{
			Right = Top + Width;

			Bottom = Left + Height;
		}

		public bool isInside(Rectagle r2)
		{
			if (Left >= r2.Left && Rigth <= r2.Right)
			{
				 
			}
		}
	}
}
