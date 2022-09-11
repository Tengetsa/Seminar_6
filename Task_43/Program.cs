// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint()
{
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;

    x = Math.Round(x, 2);
    y = Math.Round(y, 2);

    Console.WriteLine($"Пересечение двух прямых в точке: ({x}; {y})");
}

IntersectionPoint();
