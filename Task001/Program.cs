// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Main ();

void Main ()
{
    int length = Read("количество элементов");
   
    System.Console.WriteLine(GetPositiveNum(GetArray(length)));
}
 
int[] GetArray(int num) 
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = Read($"{i+1}-ое число");
    }
    return array;
}

int  Read(string argument)
{
    int number;
    System.Console.WriteLine($"введите {argument}");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("это не число!!!");
    }
    return number;
}

int GetPositiveNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            result++;
        }
    }
    return result;
}