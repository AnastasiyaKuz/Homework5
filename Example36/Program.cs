/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Write("Введите количество элементов массива: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[numberA];
void massiv(int numberA)
{
    for (int i = 0; i < numberA; i++)
    {
        randomArray[i] = new Random().Next(1,9);
        Console.Write(randomArray[i] + " ");
    }
}
int length(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i+2;
    }
    return sum;
}
massiv(numberA);
Console.Write($"Сумма элементов, стоящих на нечетных позициях: {length(randomArray)}");