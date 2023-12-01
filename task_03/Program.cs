// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
void GenerateArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * 20 - 10;
    }
}

double DifferenceNumber(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]<min) {
            min=arr[i];
        }
        if (arr[i]>max) {
            max=arr[i];
        }
    }
    double difference = max - min;
    Console.WriteLine(difference);
    return 0;
}

double[] array = new double[10];
GenerateArray(array);
Console.WriteLine(string.Join(", ", array));
DifferenceNumber(array);