using System;

namespace TicTacToe
{
    class Program
    {
        private static readonly Sign[] _cellSings = new Sign[9];

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            PrintBorder();

            MakeTurn(Sign.X);
            MakeTurn(Sign.O);
            MakeTurn(Sign.X);
            MakeTurn(Sign.O);
            MakeTurn(Sign.X);
            var isXWinner = IsLine(0, 1, 2)
                || IsLine(3, 4, 5)
                || IsLine(6, 7, 8)
                || IsLine(0, 3, 6)
                || IsLine(1, 4, 7)
                || IsLine(2, 5, 8)
                || IsLine(0, 4, 8)
                || IsLine(2, 4, 6);
            if (isXWinner)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Победили X!");
                return;
            }

            MakeTurn(Sign.O);

            MakeTurn(Sign.X);
            MakeTurn(Sign.O);
            MakeTurn(Sign.X);

            Console.SetCursorPosition(0, 5);
            Console.ReadLine();
        }

        private static void MoveCursor(int left, int top)
        {
            int offsetX = 1;
            int offsetY = 1;
            Console.SetCursorPosition(offsetX + left, offsetY + top);
        }

        private static bool IsLine(int cellIndex1, int cellIndex2, int cellIndex3)
        {
            return _cellSings[cellIndex1] == Sign.X && _cellSings[cellIndex2] == Sign.X && _cellSings[cellIndex3] == Sign.X;
        }

        private static void MakeTurn(Sign sign)
        {
            bool isRightKeyPressed = false;

            while (!isRightKeyPressed)
            {
                isRightKeyPressed = true;
                ConsoleKey pressedKey = Console.ReadKey(true)
                                               .Key;

                if (pressedKey == ConsoleKey.NumPad1)
                {
                    if (_cellSings[0] == Sign.Empty)
                    {
                        MoveCursor(0, 2);
                        _cellSings[0] = sign;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }

                else if (pressedKey == ConsoleKey.NumPad2)
                {
                    if (_cellSings[1] == Sign.Empty)
                    {
                        MoveCursor(1, 2);
                        _cellSings[1] = sign;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad3)
                {
                    if (_cellSings[2] == Sign.Empty)
                    {
                        MoveCursor(2, 2);
                        _cellSings[2] = sign;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad4)
                {
                    if (_cellSings[3] == Sign.Empty)
                    {
                        MoveCursor(0, 1);
                        _cellSings[3] = sign;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad5)
                {
                    if (_cellSings[4] == Sign.Empty)
                    {
                        MoveCursor(1, 1);
                        _cellSings[4] = sign;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad6)
                {
                    if (_cellSings[5] == Sign.Empty)
                    {
                        MoveCursor(2, 1);
                        _cellSings[5] = sign;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad7)
                {
                    if (_cellSings[6] == Sign.Empty)
                    {
                        MoveCursor(0, 0);
                        _cellSings[6] = sign;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad8)
                {
                    if (_cellSings[7] == Sign.Empty)
                    {
                        MoveCursor(1, 0);
                        _cellSings[7] = sign;
                    }
                    else
                    {
                        isRightKeyPressed = false;
                    }
                }
                else if (pressedKey == ConsoleKey.NumPad9)
                {
                    if (_cellSings[8] == Sign.Empty)
                    {
                        MoveCursor(2, 0);
                        _cellSings[8] = sign;
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

            Console.Write(sign);
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
