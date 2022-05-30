/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] InitArray(int length)                 //метод, который создает массив из элементов в промежутке от [-10, 10] для наглядности
{
    int[] array = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-10, 11); 
    }

    return array;
}

void PrintArray(int [] array)                 //метод вывода массива на консоль
{
foreach(int item in array)
Console.Write($"{item} ");
}

int GetSummOddNumbers(int [] array)            //метод, который считает сумму нечетных чисел в заданном массиве
{
int summ = 0;

foreach(int item in array)
{
    if(item % 2 != 0)
        summ += item;
}

return summ;
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.WriteLine("Полученный массив:");
PrintArray(arr);
Console.WriteLine();

int SummOddNumbers = GetSummOddNumbers(arr);
Console.WriteLine($"Сумма нечетных чисел в заданном массиве = {SummOddNumbers}");

