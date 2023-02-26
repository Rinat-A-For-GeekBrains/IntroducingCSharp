// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenArray(int size, int leftRange, int rightRange)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(leftRange, rightRange + 1);
            }
            return array;
        }
void PrintArray(int[] array)
    {
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    }

int OddCount(int[] arr)
        {int count =0;
            for (int i =0; i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        int[] MyArray = GenArray(120, 99, 1000);//[99-1000) - положительные трехзначные числа
        PrintArray(MyArray);
        Console.WriteLine("Количество четных элементов =" + OddCount(MyArray));