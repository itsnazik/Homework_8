// Задача #60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int[,,] CreateArray(int row, int column, int dep)
{
    int[,,] arr = new int[row, column, dep];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++) 
            { 
                arr[i, j, k] = GetUniqueValue(arr, i, j, k); 
            }
        }
    }
    return arr;
}

static int GetUniqueValue(int[,,] arr, int i, int j, int k)
{
    Random random = new Random();
    int val = default;
    bool exist = true;
    int min = 10;
    int max = 99;
    while (exist)
    {
        bool _break = false;
        val = random.Next(min, max + 1);
        for (int a = 0; a < arr.GetLength(0); a++)
        {
            if (_break) { break; }
            for (int b = 0; b < arr.GetLength(1); b++)
            {
                if (_break) { break; }
                for (int c = 0; c < arr.GetLength(2); c++)
                {
                    if (arr[a, b, c] == val) { _break = true; break; }
                    if (a == i && b == j && c == k) { exist = false; }
                }
            }
        }
    }
    return val;
}

static void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(" ");
            for (int k = 0; k < arr.GetLength(2); k++) 
            { 
                Console.Write($"{arr[i, j, k],1}({i},{j},{k}) "); 
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите число");
Console.Write("X: "); 
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: "); 
int Y = Convert.ToInt32(Console.ReadLine());

Console.Write("Z: "); 
int Z = Convert.ToInt32(Console.ReadLine());

int[,,] my_array = CreateArray(X, Y, Z);
PrintArray(my_array);
Console.ReadLine();
