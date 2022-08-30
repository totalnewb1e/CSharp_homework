// Zada4a 2.

/*
Console.Write("Enter 1st value: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd value: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"{num1} is bigger then {num2} ");
}
else
{
    if(num1 == num2)
    Console.WriteLine($" {num1} equal {num2} ");
    else
    Console.WriteLine($"{num2} is bigger then {num1} ");
}
*/

// Zada4a 4.

/*
Console.Write("Enter 1st value: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd value: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 3rd value: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.WriteLine($" maximum number is {max} ");
*/

// Zada4a 6.

/*
Console.Write("Enter ur value: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num %2 == 0) // Остаток от деления на "2" - %2, возможно найти отстаток от деления на любое число и получить также любое. " %3 == 3 ".
{
    Console.WriteLine($" {num} is even ");
}
else
{
    Console.WriteLine($" {num} is odd");
}
*/

// Zada4a 8.

/*
Console.Write("Enter ur num: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
while(current <= num)
{
    if(current %2 == 0)                  // Не совсем понял правильно ли синтаксически написал, однако сработало с первого раза. Вроде программа работает без ошибок))
    Console.Write(current + " ");
    current++;      
}
*/

// Zada4a 10

//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// void SecondDigitOf3digitNum(int num)
// {
//     if (num < 100 || num > 999)
//         Console.WriteLine(" entered value is not three-digit number ");
//     else
//     {
//         int dec = num / 10 % 10;
//         Console.WriteLine($" second digit is {dec} ");
//     }
// }
// Console.Write("Enter three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// SecondDigitOf3digitNum(number);


// Zada4a 13

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// void ThirdDigitOfAnyNum(int answer)
// {
//     int num = answer;
//     if (answer >= 100)
//     {
//         while(answer > 1000)
//         {
//             answer /= 10;
//         }
//         answer %= 10;
//         Console.WriteLine($" 3rd digit of {num} is {answer} ");
//     }
//     else
//     {
//         Console.WriteLine($" {num} do not've a 3rd digit ");
//     }
// }

// Console.Write("Enter positive value: ");
// int number = Convert.ToInt32(Console.ReadLine());

// ThirdDigitOfAnyNum(number);

// Zada4a 15

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void DaysOfTheWeek(int weekday)
// {
//     if(weekday < 0 || weekday >= 8 )
//     {
//         Console.WriteLine($" please enter value equal the day of the week from 1 to 7 ");
//     }
//     if(weekday <= 5)
//     {
//         Console.WriteLine($" this's a weekday ");
//     }
//     else
//     {
//         Console.WriteLine($" this's a weekend ");
//     }
// }


// Console.Write("Enter day of the week from 1 to 7: ");
// int dayOftheWeek = Convert.ToInt32(Console.ReadLine());

// DaysOfTheWeek(dayOftheWeek);

// Zada4a 15 ewe raz

// void DaysOfTheWeek(int weekday)
// {
//     if(weekday < 1 || weekday >= 8 )
//     {
//         Console.WriteLine($" please enter value equal the day of the week from 1 to 7 ");
//     }
//     if(weekday == 1)
//         Console.WriteLine($" this's a monday ");
//     if(weekday == 2)
//         Console.WriteLine($" this's a tuesday ");
//     if(weekday == 3)
//         Console.WriteLine($" this's a wednesday ");
//     if(weekday == 4)
//         Console.WriteLine($" this's a thusday ");
//     if(weekday == 5)
//         Console.WriteLine($" this's a friday ");
//     if(weekday == 6)
//         Console.WriteLine($" this's a saturady ");
//     if(weekday == 7)
//         Console.WriteLine($" this's a sunday ");
// }


// Console.Write("Enter day of the week from 1 to 7: ");
// int dayOftheWeek = Convert.ToInt32(Console.ReadLine());

// DaysOfTheWeek(dayOftheWeek);

// Zada4a 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void CheckPalindrome(int number)
// {
//     int n5 = number % 10;
//     int n4 = number / 10 % 10;
//     int n2 = number / 1000 % 10;
//     int n1 = number / 10000;

//     if(n1 == n5 && n2 == n4)
//     {
//         Console.WriteLine($"{number} is polindrome");
//     }
//     else
//     {
//         Console.WriteLine($"{number} is not polindrome");
//     }
// }
// Console.Write("Enter five-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// CheckPalindrome(num);

// Zada4a 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double FindDistance(double x1, double y1, double x2, double y2, double z1, double z2)
// {
//     return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
// }

// Console.Write(" Enter 1st dot coordinates x-axis: ");
// double xA = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Enter 1st dot coordinates y-axis: ");
// double yA = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Enter 1st dot coordinates z-axis: ");
// double zA = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Enter 2nd dot coordinates x-axis: ");
// double xB = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Enter 2nd dot coordinates y-axis: ");
// double yB = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Enter 2nd dot coordinates z-axis: ");
// double zB = Convert.ToDouble(Console.ReadLine());

// double dist = FindDistance(xA, yA, xB, yB, zA, zB);
// Console.WriteLine($" distance between entered dots is {dist} ");


// Zada4a 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Cubes(int num)
// {
//     for (int counter = 1; counter <= num; counter++)
//     {
//         Console.Write($" {counter * counter * counter} ");
//     }
// }

// Console.Write(" Enter value ");
// int num = Convert.ToInt32(Console.ReadLine());

// Cubes(num);

// Zada4a 25

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// void Exponentiation(double A, int B) // 3 , 5
// {   
//     double result = 1;
//     for(int count = 1; count <= B; count++)
//     {
// result *= A;                                // Math.Pow(A, B);
//     }
//     Console.WriteLine($" power of {B} to base {A} is {result} ");
// }
// Console.Write(" Enter base: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Enter power: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Exponentiation(a, b);

// Zada4a

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// void NumSum(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     Console.WriteLine($"sum of digits of entered number is {sum}");
// }

// Console.Write("Enter value: ");
// int num = Convert.ToInt32(Console.ReadLine());

// NumSum(num);


// Zada4a 29

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// int[] CreateUsersArray()
// {   
//     Console.Write("Enter the size of the array: ");

//     int count = Convert.ToInt32(Console.ReadLine());
//     int[] newArray = new int[count];

//     for (int i = 0; i < newArray.Length; i++)
//     {   
//         Console.Write($"\nEnter the element of array under index {i}: "); //    "\n" делает пустую строку в косоли
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

// ShowArray(CreateUsersArray());