//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.WriteLine("Найдём точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double k1 = DataEntry("Введите число k1: ");
double b1 = DataEntry("Введите число b1: ");
double k2 = DataEntry("Введите число k2: ");
double b2 = DataEntry("Введите число b2: ");


if (k1==k2 & b1==b2)
{
    Console.WriteLine("Прямые параллельны и не имеют точки пересечения");
}
else
{
    double result = (b2-b1)/(k1-k2);
    double x = Math.Round(result, 3);
    double y = Math.Round((k1*x+b1), 3);
    Console.WriteLine("Прямые пересекутся в точке с координатами x = " + x + "; y = " + y);
}
