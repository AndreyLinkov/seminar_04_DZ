// Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

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
        if (arr[i]%2==0) {
            count++;
        }
    }
    Console.WriteLine(count);
}


int[] array = new int[10];
GenerateArray(array);
Console.WriteLine(string.Join(", ", array));
FindNumber(array);