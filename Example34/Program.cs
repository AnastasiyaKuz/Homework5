/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Write("Введите количество элементов массива");
int numberA = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[numberA];
void massiv(int numberA)
{
    for (int i = 0; i < numberA; i++)
    {
        randomArray[i] = new Random().Next(99,999);
        Console.Write(randomArray[i] + " ");
    }
}
int kol(int[] randomArray)
{
    int kol = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i]%2==0) 
        kol = kol + 1;  
    }
    return kol;
}
massiv(numberA);
Console.Write($"Количество четных чисел в массиве: {kol(randomArray)}");