using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
	class Walls 
	{
		List<Figure> wallList;
		public Walls(int mapWidth, int mapHeight)
		{
			wallList = new List<Figure>();

			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
			VerticalLine righttLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

			wallList.Add(upLine);
			wallList.Add(downLine);
			wallList.Add(leftLine);
			wallList.Add(righttLine);
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var wall in wallList)
			{
				if (wall.IsHit(figure))
				{
					return true;
				}
			}
			return false;
		}

		public void Draw()
		{
			foreach (var wall in wallList)
			{
				wall.Draw();
			}
		}
	}

	
}
