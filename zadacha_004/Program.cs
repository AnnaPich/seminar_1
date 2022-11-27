//Задача 4:
//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показыает все целые числв от -N до N.

Console.Clear();
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;
int argument = - number;
Console.Write($"целые числа: {argument}, ");

while(count < number * 2)
{
    argument = argument + 1;
    Console.Write($"{argument}, ");
    count = count + 1;   
}


