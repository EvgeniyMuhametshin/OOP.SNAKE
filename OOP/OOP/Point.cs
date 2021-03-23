﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	class Point
	{
		public int x;
		public int y;
		public char sym;

		public Point(int _x, int _y, char _sym)//Создание конструктора Инкапсуляция
		{
			x = _x;
			y = _y;
			sym = _sym;
		}

		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
	}
}
