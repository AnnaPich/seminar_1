//Задача 2:
//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3-> среда
// 5-> пятница

Console.Clear();
Console.Write("Введите целое число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 3) 
{
    Console.Write("Сегодня среда");
}
else
{
    if(number == 5)
    {
        Console.Write("Сегодня пятница");   
    }
     else
    {
        Console.Write("Введите другое число");
    }   
}


