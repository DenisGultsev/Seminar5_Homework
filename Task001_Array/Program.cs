// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[4]; // создание массива из 4 элементов

// заполнение массива случайными положительными трёхзначными числами
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(100, 1000);
}

int count = 0;
foreach (int num in arr)
{
    if (num % 2 == 0) // проверка на четность
    {
        count++;
    }
}

// вывод результата в консоль
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
    if (i < arr.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine($"] -> {count}");