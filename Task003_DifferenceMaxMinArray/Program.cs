// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Введите 5 вещественных чисел через пробел:");

string input = Console.ReadLine();
// Разделение введенных чисел на массив по пробелу
string[] strArr = input.Split(' ');

if (strArr.Length != 5)
{
    Console.WriteLine("Введите ровно 5 вещественных чисел, разделенных пробелами.");
    return; // Если введено не 5 чисел, завершаем программу
}

// Создание массива вещественных чисел
double[] arr = new double[strArr.Length];

for (int i = 0; i < strArr.Length; i++)
{
    // Попытка преобразовать строку в число
    if (!double.TryParse(strArr[i], out arr[i]))
    {
        Console.WriteLine("Введите только вещественные числа, разделенные пробелами.");
        return; // Если преобразование не удалось, завершаем программу
    }
}

double max = arr[0];
double min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }

    if (arr[i] < min)
    {
        min = arr[i];
    }
}

double diff = max - min;
Console.WriteLine();
Console.WriteLine("[" + string.Join(", ", arr) + "] => " + max + " - " + min + " = " + diff);