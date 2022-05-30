/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

P.S.:
Вещественные числа — это числа, у которых есть дробная часть (она может быть нулевой). Они могут быть положительными или отрицательными
Выбрал тип данных float, но не смог разобраться почему в массив генерируются только целые числа. 
*/

float[] InitArray(int length)                 //метод, который создает массив из вещественных чисел в промежутке от [-10, 10]
{
    float[] array = new float[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-10, 11);
    }

    return array;
}

void PrintArray(float[] array)                 //метод вывода массива на консоль
{
    foreach (int item in array)
        Console.Write($"{item}  ");
}

void DiffMaxMin(float[] array)                // метод поиска минимального и максимального значения в массиве и их разности
{
    float min = array[0];
    float max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    Console.WriteLine($"Минимальный элемент в массиве = {min}");
    Console.WriteLine($"Максимальный элемент в массиве = {max}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом = {max - min}");
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
float[] arr = InitArray(length);

Console.WriteLine("Полученный массив:");
PrintArray(arr);
Console.WriteLine();

DiffMaxMin(arr);

