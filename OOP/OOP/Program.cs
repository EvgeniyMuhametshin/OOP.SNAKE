﻿using System;
using System.Collections.Generic;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point(1, 3, '*');//Обращение к классу Point()
			p1.Draw();

			Point p2 = new Point(5, 4, '#');
			p2.Draw();

			HorizontalLine line = new HorizontalLine(5, 10, 8, '+');	
			line.Drow();

			Console.ReadKey();
		}
	}
}
