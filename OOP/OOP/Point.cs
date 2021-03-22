using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	class Point
	{
		public int _x;
		public int _y;
		public char _sym;

		public void draw(int x, int y, char sym)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
	}
}
