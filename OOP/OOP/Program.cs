using System;
using System.Collections.Generic;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
			VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
			VerticalLine righttLine = new VerticalLine(0, 24, 78, '+');

			upLine.Drow();
			downLine.Drow();
			leftLine.Drow();
			righttLine.Drow();

			Point p = new Point(4, 5, '*');

			Snake snake = new Snake(p, 4, Direction.RIGHT);
		}
	}
}
