using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShooterImprovement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// инструкция
			Console.WriteLine("Use the arrow keys or W/A/S/D to move the cursor. Press Esc to exit");
			//  контроль для работы цикла
			bool running = true;

			while (running)
			{
				//проверка нажатия клавиши
				if (Console.KeyAvailable)
				{
					//Метод Console.ReadKey считывает нажатую клавишу 
					//с консоли. Возвращает структуру ConsoleKeyInfo, 
					//которая содержит информацию о нажатой клавише, 
					//символе и состоянии модификаторов клавиш(Shift, Alt, Ctrl).

					//чтение нажатой клавиши, не выводя в консоль
					var key = Console.ReadKey(true).Key;   // 'true' - указывает, нажатая клавиша не будет отображаться в консоли
					switch (key)
					{
						//ConsoleKey — это перечисление(enum) в пространстве имен System в.NET, 
						//которое содержит константы для всех клавиш, которые можно распознать 
						//на клавиатуре.Оно используется вместе с методами Console.ReadKey и ConsoleKeyInfo
						//для работы с вводом клавиш в консольных приложениях.
						case ConsoleKey.UpArrow:
						case ConsoleKey.W:
							MoveCursorUp();
							break;
						case ConsoleKey.DownArrow:
						case ConsoleKey.S:
							MoveCursorDown();
							break;
						case ConsoleKey.LeftArrow:
						case ConsoleKey.A:
							MoveCursorLeft();
							break;
						case ConsoleKey.RightArrow:
						case ConsoleKey.D:
							MoveCursorRight();
							break;
						case ConsoleKey.Escape:
							running = false;  // завершение цикла при нажатии Esc
							break;
					}
				}
			}
		}
		static void MoveCursorUp()
		{
			// получаем текущие координаты курсора

			int x = Console.CursorLeft;  //возвращает текущую позицию по горизонтали (колонка)
			int y = Console.CursorTop;   // возвращает текущую позицию по вертикали (строка)

			//проверка, чтобы курсор не вышел за верхнюю границу
			if (y > 0)
			{
				//установка курсора на новую позицию
				Console.SetCursorPosition(x, y - 1);
			}
		}
		static void MoveCursorDown()
		{
			 //получение текущих координат курсора
			int x = Console.CursorLeft;
			int y = Console.CursorTop;

			// проверка курсора на выход за нижнюю границу
			if (y < Console.WindowHeight - 1)
			{
				//установка на новую позицию
				Console.SetCursorPosition(x, y + 1);
			}
		}
		static void MoveCursorLeft()
		{
			int x = Console.CursorLeft;
			int y = Console.CursorTop;

			//проверка  курсора на выход за левую границу
			if (x > 0)
			{
				// установка в новую  позицию
				Console.SetCursorPosition(x - 1, y);
			}
		}
		static void MoveCursorRight()
		{
			int x = Console.CursorLeft;
			int y = Console.CursorTop;
			//проверка курсора на выход за правую границу
			if (x < Console.WindowWidth - 1)
			{
				//установка в новую позицию
				Console.SetCursorPosition(x + 1, y);
			}
		}
	}
}