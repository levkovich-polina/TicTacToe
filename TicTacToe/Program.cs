﻿using System;

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
            bool isXWinner = IsFilledLineExist(Sign.X);
            if (isXWinner)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Победили X!");
                return;
            }

            MakeTurn(Sign.O);
            bool isOWinner = IsFilledLineExist(Sign.O);
            if (isOWinner)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Победили O!");
                return;
            }

            MakeTurn(Sign.X);
            bool isXWinner1 = IsFilledLineExist(Sign.X);
            if (isXWinner1)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Победили X!");
                return;
            }

            MakeTurn(Sign.O);
            bool isOWinner1 = IsFilledLineExist(Sign.O);
            if (isOWinner1)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Победили O!");
                return;
            }

            MakeTurn(Sign.X);
            bool isXWinner2 = IsFilledLineExist(Sign.X);
            if (isXWinner2)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Победили X!");
                return;
            }

            Console.SetCursorPosition(0, 5);
            Console.WriteLine("Ничья!");
            Console.ReadLine();
        }

        private static void MoveCursor(int left, int top)
        {
            int offsetX = 1;
            int offsetY = 1;
            Console.SetCursorPosition(offsetX + left, offsetY + top);
        }

        private static bool IsLineFilled(int cellIndex1, int cellIndex2, int cellIndex3, Sign sign)
        {
            return _cellSings[cellIndex1] == sign && _cellSings[cellIndex2] == sign && _cellSings[cellIndex3] == sign;
        }

        private static void MakeTurn(Sign sign)
        {
            bool isRightKeyPressed = false;

            while (!isRightKeyPressed)
            {
                isRightKeyPressed = true;
                ConsoleKey pressedKey = Console.ReadKey(true)
                                               .Key;

                int keyNumber = (int) pressedKey - 96;
                int cellIndex = keyNumber - 1;
                int leftOffset = cellIndex % 3;
                int topOffset = 2 - (cellIndex / 3);

                if (_cellSings[cellIndex] == Sign.Empty)
                {
                    MoveCursor(leftOffset, topOffset);
                    _cellSings[cellIndex] = sign;
                }
                else
                {
                    isRightKeyPressed = false;
                }
            }

            Console.Write(sign);
        }

        private static bool IsFilledLineExist(Sign sign)
        {
            bool isFilledLineExist = IsLineFilled(0, 1, 2, sign)
                || IsLineFilled(3, 4, 5, sign)
                || IsLineFilled(6, 7, 8, sign)
                || IsLineFilled(0, 3, 6, sign)
                || IsLineFilled(1, 4, 7, sign)
                || IsLineFilled(2, 5, 8, sign)
                || IsLineFilled(0, 4, 8, sign)
                || IsLineFilled(2, 4, 6, sign);
            return isFilledLineExist;
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
