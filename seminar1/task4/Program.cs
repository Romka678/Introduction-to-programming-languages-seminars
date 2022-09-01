//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8
Console.WriteLine("Введите трехзначное число:");
int N = Convert.ToInt32(Console.ReadLine());
while((N > 999 || N < -999) || (N < 99 && N >= 0) || (N > -99 && N <= 0))
{
    Console.WriteLine("Число не трехзначное.");
    Console.WriteLine("Введите трехзначное число:");
    N = Convert.ToInt32(Console.ReadLine());
}
int res = N%10;
Console.WriteLine(Math.Abs(res));
