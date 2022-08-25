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
//         int ed = num / 10;
//         int dec = ed % 10;
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