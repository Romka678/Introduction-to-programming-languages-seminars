// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int a = Convert.ToInt16(Console.ReadLine());
if(a%2 == 0){
    Console.WriteLine("Число четное.");
}
else{
    Console.WriteLine("Число нечетное.");
}
