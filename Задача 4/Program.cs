using System;

class Program
{
    static void Main()
    {
        // Пример двумерного массива
        int[,] array = {
            {4, 2, 7, 5},
            {1, 9, 3, 8},
            {6, 0, 2, 4},
            {3, 5, 1, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        DeleteRowAndColumnWithMinElement(ref array);

        Console.WriteLine("\nМассив после удаления строки и столбца:");
        PrintArray(array);
    }

    static void DeleteRowAndColumnWithMinElement(ref int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        // Находим индексы минимального элемента
        int minRow = 0, minCol = 0;
        int minElement = array[minRow, minCol];

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        // Создаем новый массив без удаленной строки и столбца
        int[,] newArray = new int[rowCount - 1, colCount - 1];

        for (int i = 0, newRow = 0; i < rowCount; i++)
        {
            if (i == minRow)
                continue;

            for (int j = 0, newCol = 0; j < colCount; j++)
            {
                if (j == minCol)
                    continue;

                newArray[newRow, newCol] = array[i, j];
                newCol++;
            }

            newRow++;
        }

        array = newArray;
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
