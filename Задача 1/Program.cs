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

        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        int result = GetArrayElement(array, row, col);

        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента: {result}");
        }
        else
        {
            Console.WriteLine("Элемент с такими координатами отсутствует в массиве.");
        }
    }

    static int GetArrayElement(int[,] array, int row, int col)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        if (row >= 0 && row < rowCount && col >= 0 && col < colCount)
        {
            return array[row, col];
        }

        // Возвращаем int.MinValue, чтобы показать, что элемент не найден
        return int.MinValue;
    }
}
