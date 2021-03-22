using System;
using System.Collections.Generic;

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

			List<int> numList = new List<int>();//Класс Список
			numList.Add(0);
			numList.Add(1);
			numList.Add(2);

			//Обращение к значениям
			int x = numList[0];
			int y = numList[1];
			int z = numList[2];

			//Просмотреть все значения из списка
			foreach (int i in numList)
			{
				Console.WriteLine(i);
			}

			//Удаление числа
			numList.RemoveAt(0);

			//Добавиль в лист
			List <Point> pList = new List<Point>();
			pList.Add(p1);
			pList.Add(p2);

			Console.ReadKey();
		}
	}
}
