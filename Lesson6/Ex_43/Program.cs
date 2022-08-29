Console.WriteLine("Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются вами далее");
Console.WriteLine("Задайте значение для b1");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение для b2");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение для k1");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение для k2");
float k2 = Convert.ToInt32(Console.ReadLine());

float x = - (b1 - b2) / (k1 - k2);
float y = k2 * x + b2;

Console.WriteLine("Ответ");
Console.WriteLine(x + ";" + y);