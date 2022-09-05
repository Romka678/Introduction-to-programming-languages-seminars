//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int a = Math.Abs(Convert.ToInt16(Console.ReadLine()));
while(!((a > 100) && (a < 999))){
    Console.WriteLine("Число не является трехзначным!");
    Console.WriteLine("Введите трехзначное число:");
    a = Math.Abs(Convert.ToInt16(Console.ReadLine()));
}
int b = (a/10)%10;
Console.WriteLine("Вторая цифра этого числа: " + b);