Start();

void Start()
{
    while(true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        System.Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        System.Console.WriteLine("Enter 0 to end");

        int NumTask = int.Parse(Console.ReadLine());
        switch (NumTask)
        {
            case 0: return; break;
            case 41: DigitsGreaterThanZero(); break;
            case 43: CrossingPoint(); break;
            default: System.Console.WriteLine("Enter 41, 43 or 0"); break; 
        }
    }
}

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void DigitsGreaterThanZero()
{
    System.Console.WriteLine("Enter some numbers(use spacebar): ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = 0;
 
    for (int i = 0; i < arr.Length; i++)
    {
    if (arr[i] > 0)
    {
        count++;
    }
    }
 
Console.WriteLine($"Numbers > 0 = {count}");
}

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossingPoint()
{
    double b1 = GetValue("b1");
    double k1 = GetValue("k1");
    double b2 = GetValue("b2");
    double k2 = GetValue("k2");

    double x = -(b1 - b2)/(k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}


double GetValue(string str)
{
    System.Console.WriteLine($"Enter value {str}");
    double a = Convert.ToDouble(Console.ReadLine());
    return a;
}