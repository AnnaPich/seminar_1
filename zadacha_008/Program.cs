//Семинар 2 Задача 3(14)
// Напишите программу, которая принимает на вход число
//и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();

Console.Write("Введите целое число:");
int number = int.Parse(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0)// && - знак "И" между условиями
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}