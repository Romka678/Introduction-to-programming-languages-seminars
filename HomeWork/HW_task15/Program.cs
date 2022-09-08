//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число, соответствующее дню недели.");
int a = Convert.ToInt16(Console.ReadLine());
while(a > 7 || a < 1){
	Console.WriteLine("Число не является днем недели!");
	Console.WriteLine("Введите число, соответствующее дню недели.");
    a = Convert.ToInt16(Console.ReadLine());
    }
if(a == 6 || a == 7) Console.WriteLine("Это выходной!");
else Console.WriteLine("Это не выходной!");