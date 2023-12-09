using System;

class Program
{
    static void Main()
    {
        // Пример прямоугольного двумерного массива
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int minRow = FindRowWithMinSum(array);

        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minRow + 1}"); // +1, так как нумерация строк начинается с 1
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        int minSum = int.MaxValue;
        int minRow = -1;

        for (int i = 0; i < rowCount; i++)
        {
            int currentSum = 0;

            for (int j = 0; j < colCount; j++)
            {
                currentSum += array[i, j];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minRow = i;
            }
        }

        return minRow;
    }

    static void PrintArray(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
