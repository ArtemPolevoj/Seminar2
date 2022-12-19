using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
	public class GetNumber
	{
		public static void second()
		{
			Console.WriteLine("\nПолучение второй цифры числа.");
			int number = GetValue.number("Введите трёхзначное число:");
			int x = number / 10;
			int y = x % 10;
			Console.WriteLine("Вторая цифра числа " + number + " - " + y);
			
		}


		public static void third()
		{
			

			Console.WriteLine("\nПолучение третьей цифры числа.");


			int number = GetValue.number("Введите число");
			string numStr = number.ToString();

			//Почему при переносе строки int num = int.Parse(numStr[2].ToString());
			//в это место, при вводе двухзначного числа программа "падает"?

			if (numStr.Length <= 2)
			{
				Console.WriteLine("Третьей цифры нет");

			}
			else
			{
				int num = int.Parse(numStr[2].ToString());
				Console.WriteLine("Третья цифра числа " + number + " - " + num);
			}
			
		}

	}
}
