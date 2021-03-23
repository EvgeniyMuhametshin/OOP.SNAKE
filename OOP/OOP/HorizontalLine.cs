using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	class HorizontalLine
	{
		List<Point> pList;//Лист для создания линии

		public HorizontalLine(int xLeft, int xRight, int y, char sym)//Конструктор для создания линии
		{
			pList = new List<Point>();//Пустой список

			for (int x = xLeft; x <= xRight; x++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}

		public void Drow()
		{
			foreach (Point p in pList)
			{
				p.Draw();
			}
		}
	}
}
