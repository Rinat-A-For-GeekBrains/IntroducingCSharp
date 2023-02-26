// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

double[] GenArray(int size, int leftRange, int rightRange)
        {
            double[] array = new double[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(leftRange, rightRange + 1);
            }
            return array;
        }
void PrintArray(double[] array)
    {
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    }
double MaxElement(double[] array)
        {double max =0; 
            for (int i=0; i<array.Length; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }     
            }
            return max;
        }
double MinElement(double[] array)
    {
        double min = double.MaxValue;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i]<min)
                {
                    min = array[i];
                }          
            }
            return min;
    }

    double[] myArray = GenArray(40,0,100);
    PrintArray (myArray);

    System.Console.WriteLine($"Разность между максимальным и минимальным элементом массива = {(MaxElement(myArray)-MinElement(myArray))}");