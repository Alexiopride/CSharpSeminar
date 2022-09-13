//  Напишите программу, которая принимает на вход
//   координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//   и выдаёт номер четверти плоскости, в которой находится эта точка.

// int X = Convert.ToInt32(Console.ReadLine());
// int Y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(GetKvadrat(X, Y));

// int GetKvadrat(int x, int y)
// {
//     int sqr = 0;
//     if(x > 0 && y > 0)
//     {
//         sqr = 1;
//     }
//     else if (x < 0 && y > 0)
//     {
//     sqr = 2;
//     }
//     else if (x < 0 && y < 0)
//     {
//         sqr = 3;
//     }
//     else
//     {
//         sqr = 4;
//     }
//     return sqr;
// }
// __________________________________________________________________

// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine(GetDiapason(num));

// string GetDiapason(int quatter)
// {
//     string result;
//     if(quatter == 1)
//     {
//             result = "x > 0 && y > 0";
//     }
//     else if(quatter == 2)
//     {
//         result = "x < 0 && y > 0";
//     }    
//     else if(quatter == 3)
//     {
//         result = "x < 0 && y < 0";
//     }    
//     else
//     {
//         result = "x > 0 && y < 0";
//     }
//     return result;
// }
// _____________________________________________________________________

// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// Console.WriteLine("Enter x1");
// int x1 = Convert.ToInt32(Console.ReadLine());    
// Console.WriteLine("Enter y1");
// int y1 = Convert.ToInt32(Console.ReadLine());    
// Console.WriteLine("Enter x2");
// int x2 = Convert.ToInt32(Console.ReadLine());    
// Console.WriteLine("Enter y2");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(GetDistance(x1, y1, x2, y2));

// double GetDistance(int x1, int y1, int x2, int y2)
// {
//     double distance = 0;
//     distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
//  Метод Math.sqrt() возвращает квадратный корень числа.
//  Метод Math.pow() возвращает основание, возведённое в степень
//  сумма квадратов разности x2 - x1 * 2
//     return distance;
// }
// ______________________________________________________________________


// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// int num = Convert.ToInt32(Console.ReadLine());
// GetDashboard(num);

// void GetDashboard(int num)
// {
//     int count = 1;
//     while (count <= Math.Abs(num))
//     {
//         Console.WriteLine($"Квадрат числа {count} = {count * count}");
//         count++;
//     }
// }

// // _____________________________________________________________________
