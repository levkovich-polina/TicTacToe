using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            PrintBorder();

            MakeTurn('X');
            MakeTurn('O');
            MakeTurn('X');
            MakeTurn('O');
            MakeTurn('X');
            MakeTurn('O');
            MakeTurn('X');
            MakeTurn('O');
            MakeTurn('X');

            Console.SetCursorPosition(0, 5);
            Console.ReadLine();
        }

        private static void MoveCursor(int left, int top)
        {
            int offsetX = 1;
            int offsetY = 1;
            Console.SetCursorPosition(offsetX + left, offsetY + top);
        }

        private static void MakeTurn(char symbol)
        {
            bool isRightKeyPressed = false;

            while (!isRightKeyPressed)
            {
                isRightKeyPressed = true;
                ConsoleKey pressedKey = Console.ReadKey(true)
                                               .Key;
                if (pressedKey == ConsoleKey.NumPad1)
                {
                    MoveCursor(0, 2);
                }
                else if (pressedKey == ConsoleKey.NumPad2)
                {
                    MoveCursor(1, 2);
                }
                else if (pressedKey == ConsoleKey.NumPad3)
                {
                    MoveCursor(2, 2);
                }
                else if (pressedKey == ConsoleKey.NumPad4)
                {
                    MoveCursor(0, 1);
                }
                else if (pressedKey == ConsoleKey.NumPad5)
                {
                    MoveCursor(1, 1);
                }
                else if (pressedKey == ConsoleKey.NumPad6)
                {
                    MoveCursor(2, 1);
                }
                else if (pressedKey == ConsoleKey.NumPad7)
                {
                    MoveCursor(0, 0);
                }
                else if (pressedKey == ConsoleKey.NumPad8)
                {
                    MoveCursor(1, 0);
                }
                else if (pressedKey == ConsoleKey.NumPad9)
                {
                    MoveCursor(2, 0);
                }
                else
                {
                    isRightKeyPressed = false;
                }
            }

            Console.Write(symbol);
        }

        private static void PrintBorder()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write('╔');
            Console.SetCursorPosition(0, 4);
            Console.Write('╚');
            Console.SetCursorPosition(4, 0);
            Console.Write('╗');
            Console.SetCursorPosition(4, 4);
            Console.Write('╝');
            Console.SetCursorPosition(1, 0);
            Console.Write('═');
            Console.SetCursorPosition(2, 0);
            Console.Write('═');
            Console.SetCursorPosition(3, 0);
            Console.Write('═');
            Console.SetCursorPosition(0, 1);
            Console.Write('║');
            Console.SetCursorPosition(0, 2);
            Console.Write('║');
            Console.SetCursorPosition(0, 3);
            Console.Write('║');
            Console.SetCursorPosition(1, 4);
            Console.Write('═');
            Console.SetCursorPosition(2, 4);
            Console.Write('═');
            Console.SetCursorPosition(3, 4);
            Console.Write('═');
            Console.SetCursorPosition(4, 1);
            Console.Write('║');
            Console.SetCursorPosition(4, 2);
            Console.Write('║');
            Console.SetCursorPosition(4, 3);
            Console.Write('║');
        }
    }
}
