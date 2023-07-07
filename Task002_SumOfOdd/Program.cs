// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] numbers = new int[4]; // указываем размер массива

// заполняем массив случайными числами
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(-100, 100); // генерируем случайное число от -100 до 100
}

// находим сумму элементов, стоящих на нечетных позициях
int sum = 0;
for (int i = 1; i < numbers.Length; i += 2)
{
    sum += numbers[i];
}

// выводим результат
Console.Write("[ ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}
Console.Write($"] -> {sum}");