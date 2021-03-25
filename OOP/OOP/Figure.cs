using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	class Figure
	{
		protected List<Point> pList; //Лист для создания линии

		public void Drow()
		{
			foreach (Point p in pList)
			{
				p.Draw();
			}
		}
	}
}
