using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferenceTypesDemo
{
	class MethodParametersRef
	{
		public static void Funct(int[] arr)
		{
			arr[0] = 1;
		}

		public static void Funct(ref int[] arr)
		{
			arr[0] = 1;
		}


		public static void RefChange(int[] arr)
		{
			arr = new[] { 10 };
		}

		public static void RefChange(ref int[] arr)
		{
			arr = new[] { 10 };
		}

		public static void Demo(string[] args)
		{
			int[] arr = new int[1];
			Console.WriteLine(arr[0]);

			Funct(arr);
			Console.WriteLine(arr[0]);

			Funct(ref arr);
			Console.WriteLine(arr[0]);

			RefChange(arr);
			Console.WriteLine(arr[0]);

			RefChange(ref arr);
			Console.WriteLine(arr[0]);

			Console.Read();
		}
	}
}
