Console.Clear();
int size = InputInt("Введите размер массива ");
int[] arr = new int[size];
int count = 0;

for(int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(100,999);
}

Console.WriteLine($"Вот наш массив: [{string.Join(", ", arr)}]");

for (int i = 0; i < arr.Length; i++)
    if (arr[i] % 2 == 0)
    count++;

Console.WriteLine($"всего {arr.Length} чисел, {count} из них чётные");

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
