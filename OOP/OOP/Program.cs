using System;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point();//Обращение к классу Point()
			p1._x = 1;
			p1._y = 3;
			p1._sym = '*';

			p1.draw(p1._x, p1._y, p1._sym);

			Point p2 = new Point();
			p2._x = 5;
			p2._y = 4;
			p2._sym = '#';

			p2.draw(p2._x, p2._y, p2._sym);

			Console.ReadKey();
		}
	}
}
