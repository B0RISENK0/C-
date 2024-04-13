/* Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы. */

int[] array = new int[10];
FillingArray();
PrintArray();
Console.WriteLine();
int i = 0;

PrintArrayEl(array.Length-1,i);

void FillingArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,30);
    }
}

void PrintArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ "\t");
    }
}

void PrintArrayEl(int start, int end)
{
    if(start < end)
    {
        return;
    }
    Console.Write(array[start]+"\t");
    PrintArrayEl(start-1,end);
}

