using System;
using System.Linq;

namespace Rectangle_Position
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            Rectagle r1 = Rectagle.ReadRectangle();
            Rectagle r2 = Rectagle.ReadRectangle();

            Console.WriteLine(r1.IsInside(r2));
        }
	}

	public class Rectagle
	{
		public double Top { get; set; }

		public double Left { get; set; }

		public double Width { get; set; }

		public double Height { get; set; }

		public double Bottom
        {
            get
            {
                return Top + Width;
            }
        }

        public double Right
        {
            get
            {
                return Left + Height;
            }
        }

        public string IsInside(Rectagle r2)
        {
            if (Left >= r2.Left && Right <= r2.Right && Top >= r2.Top && Bottom <= r2.Bottom)
            {
                return "Inside";
            }

            return "Not Inside";
        }

        public static Rectagle ReadRectangle()
        {
            int[] rectangleParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Rectagle
            {
                Top = rectangleParameters[0],
                Left = rectangleParameters[1],
                Width = rectangleParameters[2],
                Height = rectangleParameters[3]
            };
        }
    }
}
