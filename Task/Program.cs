// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] arr1 = { "hello", "its", "final", "task", "for", "1st", "quarter", "=)" };
string[] newarray = new string[arr1.Length];
PrintArray(arr1);
Console.Write(" -> ");

int j = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= 3)
    {
        newarray[j] = arr1[i];
        j++;
    }
}

string[] arr2 = new string[j];
if (j == 0) Console.WriteLine("Элементов, соответствующих условию, в массиве нет.");
else
{
    for (int k = 0; k < j; k++)
    {
        arr2[k] = newarray[k];
    }
    PrintArray(arr2);
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]} ]");
}