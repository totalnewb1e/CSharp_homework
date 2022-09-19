// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// void ShowNumsInbetween(int m, int n)
// {
//     if (m < n)
//     {
//         ShowNumsInbetween(m, n - 1);
//     }

//     Console.Write(n + " ");

// }

// Console.WriteLine("Enter M value: ");
// int numM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter N value: ");
// int numN = Convert.ToInt32(Console.ReadLine());

// ShowNumsInbetween(numM, numN);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumOfNumsInbetween(int m, int n)
// {   
//     // не смог вместить сюда if (m == n) return 0 сразу вычислелния сбиваются.
//     if (m < n) return SumOfNumsInbetween(m + 1, n) + m;
//     else return m;
    
// }

// Console.WriteLine("Enter M value: ");
// int numM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter N value: ");
// int numN = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{SumOfNumsInbetween(numM, numN)}");

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int AFunc (int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return AFunc(m - 1, 1);
//     if (m > 0 && n > 0) return AFunc(m - 1, AFunc(m, n - 1));

//     return AFunc(m, n);
// }

// Console.WriteLine("Enter M value: ");
// int numM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter N value: ");
// int numN = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{AFunc(numM, numN)}");