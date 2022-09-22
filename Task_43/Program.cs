// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

void Task43()
{
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    IntersectionPoint(b1, k1, b2, k2);
}

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    if ((b2 - b1) == 0 || (k1 - k2) == 0)
    {
        Console.WriteLine($"Делить на ноль нельзя {(b2 - b1)} / {(k1 - k2)}");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;

        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"Пересечение двух прямых в точке: ({x}; {y})");
    }

}

Task43();
