// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[4, 4];
        int value;
        int row = 0;
        int col = 0;
        int direction = 0; // 0 - right, 1 - down, 2 - left, 3 - up

        Console.WriteLine("Введите значения для массива:");

        for (int i = 0; i < 16; i++)
        {
            Console.Write($"[{row},{col}] = ");
            if (int.TryParse(Console.ReadLine(), out value))
            {
                array[row, col] = value;
            }
            else
            {
                Console.WriteLine("Некорректное значение. Введите число.");
                i--;
                continue;
            }

            switch (direction)
            {
                case 0:
                    if (col == 3 || array[row, col + 1] != 0)
                    {
                        direction = 1;
                        row++;
                    }
                    else
                    {
                        col++;
                    }
                    break;
                case 1:
                    if (row == 3 || array[row + 1, col] != 0)
                    {
                        direction = 2;
                        col--;
                    }
                    else
                    {
                        row++;
                    }
                    break;
                case 2:
                    if (col == 0 || array[row, col - 1] != 0)
                    {
                        direction = 3;
                        row--;
                    }
                    else
                    {
                        col--;
                    }
                    break;
                case 3:
                    if (row == 0 || array[row - 1, col] != 0)
                    {
                        direction = 0;
                        col++;
                    }
                    else
                    {
                        row--;
                    }
                    break;
            }
        }

        Console.WriteLine("Заполненный массив:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{array[i, j],3}");
            }
            Console.WriteLine();
        }
    }
}