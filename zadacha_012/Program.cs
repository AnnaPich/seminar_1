//Семинар 3 задача 3(21):
//Напишите программу, котрая принимает на вход координаты 2-х точек
// и находит расстояние между ними в 2D пространстве.

//Метод поиска расстояния между точками:
void FindDistanceAB (int x1, int y1, int x2, int y2)
{
    double distanceAB = Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1));
    Console.Write($"Расстояние между точками А[{x1};{y1}] и В[{x2};{y2}] равно {distanceAB}");
}

//int CoordinatesPoint (int x1, int y1)
//{
//    int [] A = {x1; y1};
//}

//Метод приема введенных координат:
int DataEntryXY (string str) //называем функцию и аргумент
{
    Console.Write(str); //вывод в терминале текста: "Введите координату ..."
    int coordinate = int.Parse(Console.ReadLine()); //тело метода
    return coordinate;
}

//Прием координат:

int x1 = DataEntryXY("Введите координату x1: ");
int y1 = DataEntryXY("Введите координату y1: ");
int x2 = DataEntryXY("Введите координату x2: ");
int y2 = DataEntryXY("Введите координату y2: ");

//int A = CoordinatesPoint("Координаты точки А: ");
//int B = CoordinatesPoint("Координаты точки B: ");

//Поиск расстояния между точками:

FindDistanceAB(x1, y1, x2, y2);

