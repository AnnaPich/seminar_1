// Задача 2(18) Семинар 3
//Напишите программу, которая по заданному номеру четверти
//показывает диапазон возомжных коордитат точек в этой четверти (x и y).

Console.Clear();

int EntryQuadrunt (string str)
{
    Console.Write(str);
    int quadrant = int.Parse(Console.ReadLine());
    return quadrant;
}

void PrintRange (int quadrant)
{
    if (quadrant < 1 || quadrant > 4) Console.WriteLine("Ошибка! Введите число от 1 до 4");
    if (quadrant == 1) Console.WriteLine("Квадрант 1: X > 0, Y > 0");
    if (quadrant == 2) Console.WriteLine("Квадрант 2: X < 0, Y > 0");
    if (quadrant == 3) Console.WriteLine("Квадрант 3: X < 0, Y < 0");
    if (quadrant == 4) Console.WriteLine("Квадрант 1: X > 0, Y < 0");
}


int quadrant = EntryQuadrunt("Введите номер квадранта: ");
//Console.Write(quadrant);

PrintRange (quadrant);
