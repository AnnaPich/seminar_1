//Семинар 3: Задача 17
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X не равно 0 и Y не равно 0, и выдает номер четверти плоскости, в которой находится точка.

Console.Clear();

//Прием данных:

int DataEntryXY(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// метод для решения

void FindQadrant (int X, int Y)
{
    if(X > 0 && Y > 0) Console.WriteLine("Это первый квадрант");
    if(X < 0 && Y > 0) Console.WriteLine("Это второй квадрант");
    if(X < 0 && Y < 0) Console.WriteLine("Это третий квадрант");
    if(X > 0 && Y < 0) Console.WriteLine("Это четвертый квадрант");
}

//Программа решения: 

int X = DataEntryXY("Введите координату Х:");
//Console.WriteLine(X);
int Y = DataEntryXY("Введите координату Y:");
//Console.WriteLine(Y);

FindQadrant(X,Y);
