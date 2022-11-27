//Задача 2:
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Clear();
Console.Write("Введите целое число 1: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число 2: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

int square = number_2 * number_2;
if(number_1 == square)// проверка условия равенства 
{
    Console.Write($"Число {number_1} равно квадрату числа {number_2}");
}
else
{
    Console.Write($"Число {number_1} не равно квадрату числа {number_2}");
}

