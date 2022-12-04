//Задача 4(22) Семинар 3
//Напишите программу, которая принимает на вход число (N)
//и выдает таблицу квадратов чисел от 1 до N.

Console.Clear();

void FindSquares(int N)
{
    int number = 1;
    while (number <= N)
    {
        int result = number * number;
        Console.Write(result + ", ");
        number++;
    } 
}


int DataEntryN (string str)
{
    Console.Write (str);
    int N = int.Parse(Console.ReadLine());
    return N;
}

//Программа:

int N = DataEntryN("Введите число N:");

Console.Write($"Квадраты чисел от 1 до {N}: ");

FindSquares(N);

