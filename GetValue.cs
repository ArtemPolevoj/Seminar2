using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
	public class GetValue
	{
		public static int number(string text)
		{
			int number;

			while (true)
			{
				Console.WriteLine(text);

				string value = Console.ReadLine();

				if (int.TryParse(value, out number))
				{
					return number;
					break;
				}
				else
				{
					Console.WriteLine("Введено не верное значение");
				}				
			}
			return number;

		}
	}
}