// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double segment1 = 0;
double segment2 = 0;
double segment3 = 0;
segment1 = x2 - x1;
segment2 = y2 - y1;
segment3 = k2 - k1;
double length = Math.Sqrt(segment1 * segment1 + segment2 * segment2 + segment3 * segment3);
Console.WriteLine("The distance between points is: ");
Console.Write(($"{length:f2}"));





