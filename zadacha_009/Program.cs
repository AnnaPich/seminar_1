//Семинар 2 задча 4 (16)
//Напишите программу, которая принимает на вход 2 числа
//и проверяет, является ли одно число квадратом второго.

Console.Clear();

Console.WriteLine("Напишите число 1: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Напишите число 2: ");
int number2 = int.Parse(Console.ReadLine());

//int square1 = number1 * number1;
//int square2 = number2 * number2;

//if((number1 == square2) || (number2 == square1))
if((number1 == number2 * number2) || (number2 == number1 * number1)) 
{
    Console.Write($"{number1}, {number2} -> да");
}
else
{
    Console.Write($"{number1}, {number2} -> нет");
}