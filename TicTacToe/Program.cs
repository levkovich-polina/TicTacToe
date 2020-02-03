using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        private static bool[] _isCellFilled = new bool[9];

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
                    if (_isCellFilled[0] == false)
                    {
                        MoveCursor(0, 2);
                        _isCellFilled[0] = true;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }

                else if (pressedKey == ConsoleKey.NumPad2)
                {
                    if (_isCellFilled[1] == false)
                    {
                        MoveCursor(1, 2);
                        _isCellFilled[1] = true;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad3)
                {
                    if (_isCellFilled[2] == false)
                    {
                        MoveCursor(2, 2);
                        _isCellFilled[2] = true;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad4)
                {
                    if (_isCellFilled[3] == false)
                    {
                        MoveCursor(0, 1);
                        _isCellFilled[3] = true;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad5)
                {
                    if (_isCellFilled[4] == false)
                    {
                        MoveCursor(1, 1);
                        _isCellFilled[4] = true;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad6)
                {
                    if (_isCellFilled[5] == false)
                    {
                        MoveCursor(2, 1);
                        _isCellFilled[5] = true;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad7)
                {
                    if (_isCellFilled[6] == false)
                    {
                        MoveCursor(0, 0);
                        _isCellFilled[6] = true;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad8)
                {
                    if (_isCellFilled[7] == false)
                    {
                        MoveCursor(1, 0);
                        _isCellFilled[7] = true;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad9)
                {
                    if (_isCellFilled[8] == false)
                    {
                        MoveCursor(2, 0);
                        _isCellFilled[8] = true;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
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
