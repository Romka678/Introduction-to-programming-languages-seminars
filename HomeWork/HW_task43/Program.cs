// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToDouble(Console.ReadLine());
}

double[] Point(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1]= k1 * point[0] + b1;
    return point;
}

int i = 0;
double[] arr = new double[4];
while(i < 4)
{
    arr[i] = Read_number("Введите число.");
    i++;
}
double[] point = Point(arr[0], arr[1], arr[2], arr[3]);
Console.WriteLine($"x = {point[0]}, Y = {point[1]}");
Console.WriteLine($" {arr[0]}, {arr[1]}");
Console.WriteLine($" {arr[2]}, {arr[3]}");