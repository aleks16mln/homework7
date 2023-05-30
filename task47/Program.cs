//Задача 47. 
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.Write("Введите количество строк массива и нажмите Enter: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массиваи нажмите Enter: ");
int m = int.Parse(Console.ReadLine());

double[,] arr = new double[n, m];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-99, 99) / 10.0;
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}