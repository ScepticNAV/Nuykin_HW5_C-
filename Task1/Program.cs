/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] InitArray(int length)                 //метод, который создает массив из элементов в промежутке от [100, 999]
{
    int[] array = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000); 
    }

    return array;
}

void PrintArray(int [] array)                 //метод вывода массива на консоль
{
foreach(int item in array)
Console.Write($"{item} ");
}

int GetCountEvenNumbers(int [] array)            //метод, который считает количество четных чисел в заданном массиве
{
int summ = 0;

foreach(int item in array)
{
    if(item % 2 == 0)
        summ ++;
}

return summ;
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.WriteLine("Полученный массив:");
PrintArray(arr);
Console.WriteLine();

int CountEvenNumber = GetCountEvenNumbers(arr);
Console.WriteLine($"Количество четных чисел в заданном массиве = {CountEvenNumber}");

