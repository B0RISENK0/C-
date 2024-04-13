/* Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы. */

int M = 1;
int N = 5;

PrintNum(M,N);

void PrintNum(int start,int end)
{
    if(start>end)
    {
        return;
    }
    Console.Write(start+ " ");
    PrintNum(start+1,end);
}