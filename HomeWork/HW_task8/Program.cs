// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int N = Convert.ToInt16(Console.ReadLine());
int i = 1;
if(N == 1) Console.WriteLine("Четных чисел нет.");
else{
    if(N > 1){
        Console.Write("Все четные числа от 1 до " + N + ":");
        while(i <= N){
            if(i%2 == 0){
                Console.Write(" " + i);
                i++;
            }
            else{
                i++;
            }
        }
    }
    else{
        Console.Write("Все четные числа от 1 до " + N + ":");
        while(i >= N){
        if(i%2 == 0){
            Console.Write(" " + i);
            i--;
        }
        else{
            i--;
        }
    }
    }
}


