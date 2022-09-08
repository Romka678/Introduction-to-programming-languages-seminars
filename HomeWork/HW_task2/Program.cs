//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt16(Console.ReadLine());
if(a > b){
    Console.WriteLine("max =" + a);
    Console.WriteLine("min =" + b);
}
else{
    Console.WriteLine("max =" + b);
    Console.WriteLine("min =" + a);
}