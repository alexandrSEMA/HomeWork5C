//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int [10];

for ( int i = 0; i < array.Length; i++)
{
    array[i] = new Random() .Next(100,999);
    System.Console.WriteLine(array[i]);
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0)
    {
        count = count + 1;
    }
}
System.Console.WriteLine("В этом массиве " + count + " четных числел");