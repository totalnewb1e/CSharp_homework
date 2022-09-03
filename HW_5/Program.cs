// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных

// int[] CreateUsersArray()
// {
//     Console.Write("Enter the size of the array: ");

//     int count = Convert.ToInt32(Console.ReadLine());
//     int[] newArray = new int[count];

//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = new Random().Next(100, 1000);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("\nYour array: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }

//     Console.WriteLine();
// }

// int EvenNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }

//     return count;
// }

// int[] countOfEven = CreateUsersArray();

// ShowArray(countOfEven);

// Console.WriteLine($"\ncount of even numbers is {EvenNumber(countOfEven)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateUsersArray()
// {
//     Console.Write("\nEnter the size of the array: ");

//     int count = Convert.ToInt32(Console.ReadLine());
//     int[] newArray = new int[count];

//     Console.Write("\nEnter the minumum value of array: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("\nEnter the maximum value of array: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("\nYour array: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }

//     Console.WriteLine();
// }

// int SumOfElemetsUnderOddIndexes(int[] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//             sum += array[i];
//     }

//     return sum;
// }

// int[] sum_of_odd_i = CreateUsersArray();

// ShowArray(sum_of_odd_i);

// Console.WriteLine($"\nsum of numbers under odd indexes is {SumOfElemetsUnderOddIndexes(sum_of_odd_i)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] CreateUsersArray()
// {
//     Console.Write("\nEnter the size of the array: ");

//     int count = Convert.ToInt32(Console.ReadLine());
//     double[] newArray = new double[count];

//     Console.Write("\nEnter the minumum value of array: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("\nEnter the maximum value of array: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
//     }
//     return newArray;
// }

// void ShowArray(double[] array)
// {
//     Console.Write("\nYour array: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }

//     Console.WriteLine();
// }

// double MaxMinDiff(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     double result = max - min;
//     return result;
// }

// double[] diff_max_min = CreateUsersArray();

// ShowArray(diff_max_min);

// Console.WriteLine($"\ndifference between max value and min value is  {MaxMinDiff(diff_max_min)}");