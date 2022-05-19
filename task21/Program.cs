// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координаты точки А");
int A1 = Convert.ToInt32(Console.ReadLine());
int A2 = Convert.ToInt32(Console.ReadLine());
int A3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
int B1 = Convert.ToInt32(Console.ReadLine());
int B2 = Convert.ToInt32(Console.ReadLine());
int B3 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt((B1 - A1) * (B1 - A1) + (B2 - A2) * (B2 - A2) + (B3 - A3) * (B3 - A3));
double n = Math.Round(result, 2);
Console.WriteLine($"Расстояние между двумя точками равно {n}");