using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
	public class Week
	{
		public static string weekend()
		{
			string weekend = "";
			Console.WriteLine("\nПроверка выходого дня.");
			int number = GetValue.number("Введите номер дня недели.");
			switch (number)
			{
				case 1:
					Console.WriteLine("Рабочий день.");
					break;
				case 2:
					Console.WriteLine("Рабочий день.");
					break;
				case 3:
					Console.WriteLine("Рабочий день.");
					break;

				case 4:
					Console.WriteLine("Рабочий день.");
					break;

				case 5:
					Console.WriteLine("Рабочий день.");
					break;

				case 6:
					Console.WriteLine("Выходной день.");
					break;
				case 7:
					Console.WriteLine("Выходной день.");
					break;

				default:
					Console.WriteLine("Не корректный день недели.");
					break;
			}

			return weekend;
		}
	}
}
