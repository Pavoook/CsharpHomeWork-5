// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int lengthArray = GetSize("Задайте длину массива:");
double[] collection = new double[lengthArray];
double maximum = GetBound("Задайте максимальное значение элемента массива:");
double minimum = GetBound("Задайте минимальное значение элемента массива:");
if (ValidateBounds(maximum, minimum)) collection = CreateRandomArray(lengthArray, minimum, maximum);
PrintArray(collection);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {GetMax(collection) - GetMin(collection)}.");

int GetSize(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    while (number <= 0)
    {
        Console.WriteLine("Неверное значение. Введите целое число больше нуля:");
        number = int.Parse(Console.ReadLine());
    }
    return number;
}

double GetBound(string msg)
{
    Console.WriteLine(msg);
    double number = int.Parse(Console.ReadLine());
    return number;
}

bool ValidateBounds(double max, double min)
{
    bool valid = false;
    while (valid == false)
    {
        if (max < min)
        {
            Console.WriteLine("Ошибка. Минимум не должен быть больше максимума.");
            maximum = GetBound("Задайте максимальное значение элемента массива:");
            max = maximum;
            minimum = GetBound("Задайте минимальное значение элемента массива:");
            min = minimum;
        }
        else valid = true;
    }
    return valid;
}

double[] CreateRandomArray(int L, double min, double max)
{
    double[] array = new double[L];
    Random r = new Random();
    for (int i = 0; i < L; i++)
    {
        array[i] = r.NextDouble() * (max - min) + min;
    }
    return array;
}

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
    foreach (double i in array)
    {
        if (i > max) max = i;
    }
    return max;
}

double GetMin(double[] array)
{
    double min = array[0];
    foreach (double i in array)
    {
        if (i < min) min = i;
    }
    return min;
}
