// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] CreateUsersArray()
// {
//     Console.Write("\ndecide how many numbers u gonna enter: ");

//     int count = Convert.ToInt32(Console.ReadLine());
//     int[] newArray = new int[count];

//     Console.Write($"\nEnter ur number: ");
//     newArray[0] = Convert.ToInt32(Console.ReadLine());

//     for (int i = 1; i < newArray.Length; i++)
//     {
//         Console.Write($"\ngo on: ");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
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

// int CountOFPosivite(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] result = CreateUsersArray();

// ShowArray(result);

// Console.WriteLine($"\ncount of positive numbers uve entered is {CountOFPosivite(result)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// void intersectionPoint()
// {
//     Console.Write("\nEnter value for k1: ");
//     double k1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("\nEnter value for b1: ");
//     double b1 = Convert.ToDouble(Console.ReadLine());

//     Console.Write("\nEnter value for k2: ");
//     double k2 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("\nEnter value for b2: ");
//     double b2 = Convert.ToDouble(Console.ReadLine());

//     if (k1 != k2)
//     {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = k1 * x + b1;
//         Console.WriteLine($"intersection point of two lines with entered values is {y}; {y}");
//     }
//     else
//     {
//         if (k1 == k2 && b1 == b2)
//         Console.WriteLine($"lines are either parallel or this is the same line");
//     }

// }

// intersectionPoint();