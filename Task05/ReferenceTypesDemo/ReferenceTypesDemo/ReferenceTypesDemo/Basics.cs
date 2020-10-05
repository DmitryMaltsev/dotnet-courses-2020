using System;

namespace ReferenceTypesDemo
{
	public class BasicsDemo
	{
		public static void Demo(string[] args)
		{
			// reference

			object o = new object();
			Console.WriteLine(o);

			CPoint p = new CPoint();
			// CPoint наследник object
			Console.WriteLine(p);

			p.x = 5;
			p.y = 6;
			Console.WriteLine("x:{0} - y:{1}", p.x, p.y);

			// Различия между value и reference типами
			SPoint ps = new SPoint();
			Console.WriteLine(ps);

			CPoint p1 = p; // ссылка
			p.x = 10;
			Console.WriteLine("p1.x = {0}", p1.x);

			SPoint ps1 = ps; // копия
			ps.x = 10;
			Console.WriteLine("ps1.x = {0}", ps1.x);
		}
	}

	struct SPoint
	{
		public int x;
		public int y;
	}

	class CPoint
	{
		public int x;
		public int y;
	}
}
