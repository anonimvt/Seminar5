Console.Clear();
int[] arr = new int[5];

for(int i = 0; i < 5; i++)
{
    arr[i] = new Random().Next(1, 100);
}
// Нахождение минимального элемента массива
int min = arr[0];
for(int i = 1; i < arr.Length; i++)
{
   if(arr[i] < min)
      min = arr[i];
}

// Нахождение максимального элемента массива
int max = arr[0];
for(int i = 1; i < arr.Length; i++)
{
   if(arr[i] > max)
      max = arr[i];
}

// Нахождение разницы
int result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива =>> {result}");

// Вывод минимального и максимального элемента массива и вывод самого массива
Console.WriteLine($"Минимальный элемент массива =>> {min}");
Console.WriteLine($"Максимамльный элемент массива =>>  {max}");
Console.WriteLine($"Вот наш массив: [{string.Join(", ", arr)}]");