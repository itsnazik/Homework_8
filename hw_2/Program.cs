// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

int[,] PrintArray (int row, int column)
{
    Random random = new Random();
    int[,] array = new int[row, column];
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

static void FindMinSum (int[,] array) 
{   
    int[] summary = new int[array.GetLength(1)];
    Console.WriteLine();
    
    for (int j = 0; j < array.GetLength(0); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[j, i];
        }
        summary[j] = sum;
        Console.Write($"{ sum} ");
    }
    
    int min = summary[0];
    int index = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        if (min > summary[i])
                {
                    min = summary[i];
                    index = i;
                }
    }
    Console.WriteLine();
    Console.WriteLine("Строка с наименьшей суммой элементов: " + index);
    Console.ReadLine();
}

Console.Write("Введите количество строк: "); 
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: "); 
int columns = Convert.ToInt32(Console.ReadLine());

FindMinSum(PrintArray(rows, columns));