// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintSumOfNumber(int n, int m)
{
    int N = n;
    int M = m;
    int sum = 0;
    if(n < m)
    {
        int tmp = n;
        n = m;
        m = tmp;
    }
    while(n >= m)
    {
        sum += n;
        n--;
    }
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {N} до {M} = " + sum);
}
int n = Read_number("Введите первое число.");
int m = Read_number("Введите второе число.");
while(n <= 0 || m <= 0)
{
    Console.WriteLine("Вы ввели отрицательное число или 0. Введите другое число.");
    n = Read_number("Введите первое число.");
    m = Read_number("Введите второе число.");
}
PrintSumOfNumber(n, m);