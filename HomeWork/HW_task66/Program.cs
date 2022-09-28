// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumber(int n,int m, int sum)
{
    if(n>=m)
    {
        sum+=n;
        return SumOfNumber(n-1,m,sum);
    }
    return sum;
}
int n = Read_number("Введите первое число.");
int m = Read_number("Введите второе число.");
while(n <= 0 || m <= 0)
{
    Console.WriteLine("Вы ввели отрицательное число или 0. Введите другое число.");
    n = Read_number("Введите первое число.");
    m = Read_number("Введите второе число.");
}
int sum = 0;
if(n < m)
{
  sum =  SumOfNumber(m,n, sum);
}
else
{
   sum = SumOfNumber(n,m, sum);
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {n} до {m} = " + sum);