// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

Console.Clear();
void GenerateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
}

void FindNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 19 && arr[i] < 90) {
            count++;
        }
    }
    Console.WriteLine(count);
}


int[] array = new int[10];
GenerateArray(array);
Console.WriteLine(string.Join(", ", array));
FindNumber(array);