Console.Clear();

// Создание и заполнение массива
int[] arr = new int[4];

for(int i = 0; i < 4; i++)
{
    arr[i] = new Random().Next(1, 100);
}

// Нахождение нечетных элементов массива
int sum = 0;
for (int i = 0; i < arr.Length; i+=2)
    sum = sum + arr[i];

// Вывод массива и суммы нечетных элементов массива
Console.WriteLine($"Вот наш массив: [{string.Join(", ", arr)}]");
Console.WriteLine($"Сумма всех нечетных элементов массива: {sum}");