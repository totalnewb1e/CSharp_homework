// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandom2dArray()
// {
//     Console.Write("Enter number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter minValue: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter maxValue: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     double[,] newArray = new double[rows, columns];

//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
//             newArray[i, j] = Math.Round(newArray[i, j], 1);
//         }
//     }

//     return newArray;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($" ({array[i, j]}) " + "|");

//         Console.WriteLine();
//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// double[,] newArray = CreateRandom2dArray();

// Show2dArray(newArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Enter number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter minValue: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter maxValue: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }

//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// void FindElementByPosition(int[,] array)
// {
//     Console.WriteLine("\nChoose row: ");
//     int rowPos = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("\nChoose column: ");
//     int columnPos = Convert.ToInt32(Console.ReadLine());

//     int row = rowPos - 1;
//     int column = columnPos - 1;

//     if (row < array.GetLength(0) && column < array.GetLength(1))
//     {
//         Console.WriteLine($"ur element is {array[row, column]}");
//     }
//     else
//         Console.WriteLine($"there is no element with such positions");

// }

// int[,] myArray = CreateRandom2dArray();

// Show2dArray(myArray);

// FindElementByPosition(myArray);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] CreateRandom2dArray()
{
    Console.Write("Enter number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void AvgOfColumns(int[,] array)
{
    double[] columns = new double[array.GetLength(1)];

    Console.WriteLine("Left to right");

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            columns[j] += array[i, j];
        }
        columns[j] /= array.GetLength(0);
        Console.WriteLine($"{Math.Round(columns[j], 1)}");
    }

}

int[,] myArray = CreateRandom2dArray();

Show2dArray(myArray);

AvgOfColumns(myArray);