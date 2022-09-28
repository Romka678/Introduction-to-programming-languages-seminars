// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumber(int n)
{
    if(n != 0)
    {
        Console.Write(n + " ");
        PrintNumber(n-1);
    }
}

PrintNumber(Read_number("Введите число."));

