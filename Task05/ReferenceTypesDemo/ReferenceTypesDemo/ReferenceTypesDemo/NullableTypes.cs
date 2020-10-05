using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferenceTypesDemo
{
	public class NullableTypes
	{
		public static void Demo(string[] args)
		{
			// nullable
			int? nullable = 20;

			Console.WriteLine("nullable is a: {0}", nullable.GetType().Name);

			int n = nullable.Value;

			nullable = null;
			//n = null;

			// error
			n = nullable.Value;

			if (nullable.HasValue)
			{
				n = nullable.Value;
			}

			var myObj = (int?)null;
			myObj = 78;
		}
	}
}
