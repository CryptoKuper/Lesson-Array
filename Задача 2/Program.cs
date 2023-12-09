using System;

class Program
{
    static void Main()
    {
        // Пример двумерного массива
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        SwapFirstAndLastRows(array);

        Console.WriteLine("\nМассив после замены:");
        PrintArray(array);
    }

    static void SwapFirstAndLastRows(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        if (rowCount >= 2)
        {
            // Создаем временный массив для хранения первой строки
            int[] tempRow = new int[colCount];
            for (int j = 0; j < colCount; j++)
            {
                tempRow[j] = array[0, j];
            }

            // Копируем последнюю строку в первую
            for (int j = 0; j < colCount; j++)
            {
                array[0, j] = array[rowCount - 1, j];
            }

            // Копируем временную строку в последнюю
            for (int j = 0; j < colCount; j++)
            {
                array[rowCount - 1, j] = tempRow[j];
            }
        }
        else
        {
            Console.WriteLine("Массив слишком мал для выполнения операции.");
        }
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
