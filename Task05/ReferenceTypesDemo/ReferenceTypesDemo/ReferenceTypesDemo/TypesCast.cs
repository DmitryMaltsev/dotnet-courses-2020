using System;

namespace ReferenceTypesDemo
{
	public class TypesCastDemo
	{
		public static void Demo(string[] args)
		{
			Circle c = new Circle();
			c.X = 5;
			c.Y = 6;
			//c.r = 7; // Ошибка
			c.Radius = 7; // Вызов метода set
			Console.WriteLine(c.GetLength());

			// неявное приведение
			Figure f = new Circle();
			Console.WriteLine("Type name: {0}", f.GetType().Name);

			object o = f;
			Console.WriteLine("Type name: {0}", o.GetType().Name);

			// явное приведение
			Figure f1 = (Figure) o;
			Console.WriteLine("Type name: {0}", f1.GetType().Name);

			c = f as Circle;
			Console.WriteLine("Type name: {0}", c.GetType().Name);

			// как проверить тип при выполнении программы
			if (f is Circle)
			{
				Circle c1 = (Circle) f;
				Console.WriteLine("Type name: {0}", c1.GetType().Name);
			}

			Circle c2 = f as Circle;
			if (c2 != null)
			{
				Console.WriteLine("Type name: {0}", c2.GetType().Name);
			}

			// nullable
			int? nullable = 20;
			int n = 0;

			n = nullable.Value;

			nullable = null;
			//n = null;

			// error
			n = nullable.Value;

			if (nullable.HasValue)
			{
				n = nullable.Value;
			}

			// Неявно типизированные локальные переменные. 
			var myInt = 0;
			var myBool = true;
			var myString = "Time, marches on...";

			// Вывод имен типов, лежащих в основе этих переменных. 
			Console.WriteLine("mylnt is a: {0}", myInt.GetType().Name);
			Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
			Console.WriteLine("myString is a: {0}", myString.GetType().Name);

			var myObj = (int?) null;
			myObj = 78;
		}
	}
}
