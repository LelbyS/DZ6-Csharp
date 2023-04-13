// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Main ();

void Main ()
{
    double k1 = IntRead("k1");
    double b1 = IntRead("b1");
    double k2 = IntRead("k2");
    double b2 = IntRead("b2");

    double y = k1*Argyment(k1, b1, k2, b2) + b1;

    System.Console.WriteLine($" точка пересечения прямых ({Argyment(k1, b1, k2, b2)};{y})");

}

double Argyment(double k1, double b1, double k2, double b2)
{
    double num =1;
    if (k1 == k2)
    {
        System.Console.WriteLine("прямые парралельные - точки пересечения не существует");
    }
    else
    {
       num = (b2 - b1)/(k1 - k2);
    }
    return num;
}

int IntRead(string argument)
{
    int number;
    System.Console.WriteLine($"введите переменную {argument}");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("это не корректное число!!!");
    }
    return number;
}