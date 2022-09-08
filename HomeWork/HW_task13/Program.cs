//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int a = Math.Abs(Convert.ToInt16(Console.ReadLine()));
if(a > -100 && a < 100) Console.WriteLine("Третьей цифры нет.");
else{
    while(a > 1000) a/=10;
    int b = a%10;
    Console.WriteLine("Третья цифра этого числа: " + b);
}