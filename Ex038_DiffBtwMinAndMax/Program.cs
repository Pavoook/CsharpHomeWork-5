// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

double GetMax(double[] array)
{
    double max = array[0];
    foreach(double i in array)
    {
        if (i > max) max = i;
    }
    return max;
}

double GetMin(double[] array)
{
    double min = array[0];
    foreach(double i in array)
    {
        if (i < min) min = i;
    }
    return min;
}

double[] collection = { -102.4, 488.22, -15628.5, 12.5, 1.5, -5698.55, 3.14, 2.71 };
PrintArray(collection);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {GetMax(collection)-GetMin(collection)}.");
