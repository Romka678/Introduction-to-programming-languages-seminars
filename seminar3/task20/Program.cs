//Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
//Формула AB = √((x2 - x1)^2 + (y2 - y1)^2)

Console.WriteLine("Введите координаты первой точки.");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки.");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
double res = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
Console.WriteLine($"Расстояние между точками = {res}");
