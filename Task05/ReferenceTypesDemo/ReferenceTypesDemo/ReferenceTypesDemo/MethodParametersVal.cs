using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferenceTypesDemo
{
	public class MethodParameters
	{
		// копируется
		public static void Funct(int par)
		{
			Console.WriteLine(par);
			par = 7;
			Console.WriteLine(par);
		}

		// ссылка
		public static void Funct(ref int par)
		{
			Console.WriteLine(par);
			par = 7;
			Console.WriteLine(par);
		}

		public static void Demo(string[] args)
		{
			int x = 5;
			Console.WriteLine(x);

			Funct(x);
			Console.WriteLine(x);

			Funct(ref x);
			Console.WriteLine(x);

			Console.Read();
		}
	}
}
