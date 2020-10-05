using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferenceTypesDemo
{
	public class Figure
	{
	}

	public class Circle : Figure
	{
		// доступен только внутри класса
		private double r;

		// getter & setter по умолчанию
		public double X { get; set; }
		public double Y { get; set; }

		// обеспечивает доступ к r
		public double Radius
		{
			get
			{
				return r;
			}
			set
			{
				if (value >= 0)
					r = value;
			}
		}

		// конструкторы
		public Circle()
		{
			X = Y = 1;
		}

		public Circle(int x, int y, double r)
		{
			X = x;
			Y = y;
			this.r = r;
		}

		// методы
		public double GetLength()
		{
			return 2 * Math.PI * r;
		}

		// статический метод
		public static double GetDoublePI()
		{
			// экземплярные поля недоступны в статических методах
			//return 2 * Math.PI * r;

			return 2 * Math.PI;
		}
	}
}
