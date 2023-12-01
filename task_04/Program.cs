// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, 
// младший – на последнем. Размер массива должен быть равен количеству цифр.

void NewArray(int[] arr, string num)
{
    for (int i = 0; i < num.Length; i++)
    {
        arr[i] = int.Parse(num[i].ToString());
    }
}


int number = new Random().Next(1,100000);
Console.WriteLine(number);
string numStr = number.ToString();
int length = numStr.Length;
int[] array = new int[length];
NewArray(array, numStr);
Console.WriteLine(string.Join(", ", array));
