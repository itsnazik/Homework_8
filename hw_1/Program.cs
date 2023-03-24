// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

int[,] PrintArray (int row, int column)
{
    Random random = new Random();
    int[,] array = new int[row, column];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < row; i++)
        {
        for (int j = 0; j < column; j++)
            {
            array[i, j] = random.Next(1, 10);
            Console.Write(array[i, j] + " ");
            }
        Console.WriteLine();
        }
        Console.WriteLine();
        return array;
}

static void SortArray(int[,] array)
{
    Console.WriteLine("Отсортированный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: "); 
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: "); 
int columns = Convert.ToInt32(Console.ReadLine());

SortArray(PrintArray(rows, columns));