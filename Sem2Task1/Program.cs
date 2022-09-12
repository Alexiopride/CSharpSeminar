// Напишите программу которая выводит случайное число
//  из отрезка (10, 99) и показывает наибольшую
//  цифру числа.


// int randomNum = new Random().Next(10, 100);
// Console.WriteLine(randomNum);
// int digitFirst = randomNum / 10;
// int digitSecond = randomNum % 10;
// Console.WriteLine($"{digitFirst}, {digitSecond}");


// int randomNum = new Random().Next(10, 100);
// Console.WriteLine(randomNum);
// int digitFirst = randomNum / 10;
// int digitSecond = randomNum % 10;
// Console.WriteLine(FindMax(digitFirst, digitSecond));
// int FindMax(int num1, int num2)
// {
//     if (num1 > num2)
//     {
//         return num1;
//     }
//     return num2;
// }

// ------------------------------------------------------------------
// Напишите программу, которая будет принимать на вход
//  два числа и выводить, является ли второе число
//   кратным первому. Если число 2 не кратно числу 1,
//    то программа выводит остаток от деления.

// Console.WriteLine("Введите первое число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberB = Convert.ToInt32(Console.ReadLine());
// void Multiple(int num1, int num2)
// {
//     if (num2 % num1 == 0)
//     {
//         Console.WriteLine("Кратно");
//     }
//     else
//     {
//         Console.WriteLine($"Остаток от деления {num2 % num1}");
//     } 
// }
// Multiple(numberA, numberB);

// ----------------------------------------------------------

// Напишите программу, которая принимает на вход число
// //  и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


// Console.WriteLine("Введите число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Multiple(num1));

// bool Multiple(int num)
// {
//     return num % 7 == 0 && num % 23 ==0;
// }

// ____________________________________________________________________

// Напишите программу, которая принимает на вход два числа
//  и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Multiple(num1, num2));

// bool Multiple(int num1, int num2)
// {
//     // return num % 7 == 0 && num % 23 ==0;
//     return num1 * num1 == num2 || num2*num2 == num1;
// }

