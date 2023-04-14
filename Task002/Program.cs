// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Main ();

void Main ()
{
    double k1 = IntRead("k1");
    double b1 = IntRead("b1");
    double k2 = IntRead("k2");
    double b2 = IntRead("b2");
    double x = 1;
    double y = 1;
    if(Argyment(k1, k2))
    {
        x = (b2 - b1)/(k1 - k2);
        y = k1*(b2 - b1)/(k1 - k2) + b1;
        System.Console.WriteLine($" точка пересечения прямых ({x};{y})");
    }
}

bool Argyment(double k1, double k2)
{
    if (k1 == k2)
    {
        System.Console.WriteLine("прямые парралельные - точки пересечения не существует");
        return false;
    }
    
    return true;
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