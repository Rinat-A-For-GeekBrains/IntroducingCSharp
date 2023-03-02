// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    System.Console.WriteLine(message);
    string inputFromLine = Console.ReadLine();
    double result = double.Parse(inputFromLine);
    return result;
}

double k1 = Prompt("Введите К1");
double b1 = Prompt("Введите b1");
double k2 = Prompt("Введите К2");
double b2 = Prompt("Введите b2");

double coordx = (b2 - b1) / (k1 - k2);

if ((k1 * coordx) + b1 != (k2 * coordx) + b2)
{
    Console.WriteLine("Прямые не пересекаются");
    
}
else
{
    double coordy = (k1 * coordx) + b1;
    
    Console.WriteLine($"Прямые пересекаются в точке ({coordx}; {coordy})");
}

    
