//Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
 //двумерном массиве, и возвращает 
 //значение этого элемента или же указание, что такого элемента нет.
 //Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
 //, задан массив:
 //1 4 7 2
 //5 9 2 3
 //8 4 2 4
 //17 -> такого числа в массиве нет
 
int rows = ReadInt("Введите индекс строки и нажмите Enter: ");
int colums = ReadInt("Введите индекс столбца и нажмите Enter: ");

int[,] array = new int[rows, colums];

if (rows < array.GetLength(0) && colums < array.GetLength(1)) 
Console.WriteLine(array[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
    
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
