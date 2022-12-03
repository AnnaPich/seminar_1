//Семинар 2 задача 3
//Напишите программу, которая будет принимать на вход 2 числа и выводить: является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Clear();

//Прием чисел от пользователя:
Console.Write("Введите число 1: ");
int number1 = int.Parse (Console.ReadLine());

Console.Write ("Введите число 2: ");
int number2 = int.Parse (Console.ReadLine());

int count = number2 % number1;
if(count > 0)
{
    Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {count}");
}
else
{
    Console.WriteLine($"{number1}, {number2} -> кратно");
}