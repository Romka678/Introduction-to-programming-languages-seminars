// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число.");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
if(a < 1)
{
Console.Write($"Все квадраты чисел от 1 до {a} : ");
while(b >= a)
{
    
    Console.Write($" {Math.Pow(b,3)}");
    b-=1;
}
}
else
{
    Console.Write($"Все квадраты чисел от 1 до {a} : ");
    while(b <= a)
    {
        Console.Write($" {Math.Pow(b,3)}");
        b+=1;
    }
}

/*while(a < 1)
{
    Console.WriteLine("Введите число больше или равное 1.");
    Console.WriteLine("Введите число.");
    a = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"Все квадраты чисел от 1 до {a} : ");
while(b <= a)
{
    Console.Write($" {Math.Pow(b,3)}");
    b+=1;
}*/