using System;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point(1, 3, '*');//Обращение к классу Point()
			p1.draw(p1.x, p1.y, p1.sym);

			Point p2 = new Point(5, 4, '#');
			p2.draw(p2.x, p2.y, p2.sym);

			Console.ReadKey();
		}
	}
}
