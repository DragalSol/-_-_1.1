using System;

class SwapVertical
{
    class Program
    {
        static void Main()
        {
            // Получаем  размеры массива
            Console.Write("Введите количество строк: ");
            string inputRows = Console.ReadLine();
            int rows;

            if (inputRows != null)
            {
                int.TryParse(inputRows, out rows);
            }
            else
            {
                // Обработка ситуации, когда ввод пользователя равен null
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное значение.");
                return;
            }

            Console.Write("Введите количество столбцов: ");
            string inputColumns = Console.ReadLine();
            int columns;

            if (inputColumns != null)
            {
                int.TryParse(inputColumns, out columns);
            }
            else
            {
                // Обработка ситуации, когда ввод пользователя равен null
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное значение.");
                return;
            }

            // Инициализация двумерного массива
            int[,] array = new int[rows, columns];

            // Получаем от пользователя значения массива
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"array[{i},{j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nИсходный массив:");
            PrintArray(array);

            // Меняем местами симметричные строки
            SwapSymmetricRows(array);

            Console.WriteLine("\nМассив после обмена:");
            PrintArray(array);
        }

        static void SwapSymmetricRows(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int middleColumn = columns / 2;

            for (int i = 0; i < rows / 2; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Меняем местами элементы симметричных строк относительно середины массива
                    int temp = array[i, j];
                    array[i, j] = array[rows - 1 - i, j];
                    array[rows - 1 - i, j] = temp;
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
