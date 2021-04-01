using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	class FoodCreator
	{

		int _mapWidht;
		int _mapHeight;
		char _sym;

		Random random = new Random();

		public FoodCreator(int mapWidht, int mapHeight, char sym)
		{
			this._mapWidht = mapWidht;
			this._mapHeight = mapHeight;
			this._sym = sym;
		}

		public Point CreateFood()
		{
			int x = random.Next(2, _mapWidht - 2);
			int y = random.Next(2, _mapHeight - 2);
			return new Point(x, y, _sym);
		}
	}
}
