// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Read_number(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}

int AkkermanFunction(int n, int m)
{
    if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AkkermanFunction(n - 1, 1);
    else
      return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}

int n = Read_number("Введите первое число.");
int m = Read_number("Введите второе число.");
while(n < 0 || m < 0)
{
    Console.WriteLine("Вы ввели отрицательное число. Введите другое число.");
    n = Read_number("Введите первое число.");
    m = Read_number("Введите второе число.");
}
int res = AkkermanFunction(n , m);
Console.WriteLine($"Функция Аккремана А({n}, {m}) = " + res);