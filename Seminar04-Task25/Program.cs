// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Prompt (string message)
{
    System.Console.WriteLine(message);
    string inputFromLine = Console.ReadLine();
    int result = Convert.ToInt32(inputFromLine);
    return result;
}

int Stepen(int basis, int extent)
{
    int result = 1;
       for (int i = 0; i < extent; i++)
    {
    result = result * basis;
   
    }
    return result;
}

int basis = Prompt("Введите основание степени");
int extent = Prompt("Введите степень");
if (extent > 0){
    Console.WriteLine($"результат={Stepen(basis, extent)}");
}
else 
Console.WriteLine("Число степени не натуральное");
