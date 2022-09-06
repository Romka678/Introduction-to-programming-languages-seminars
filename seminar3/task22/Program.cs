//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
Console.WriteLine("Введите число.");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
if(a < 1)
{
Console.Write($"Все квадраты чисел от 1 до {a} : ");
while(b >= a)
{
    
    Console.Write($" {b*b}");
    b-=1;
}
}
else
{
    Console.Write($"Все квадраты чисел от 1 до {a} : ");
    while(b <= a)
    {
        Console.Write($" {b*b}");
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
    Console.Write($" {b*b}");
    b+=1;
}*/