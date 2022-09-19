//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int [4];

int max = array[0];

for ( int i = 0; i < array.Length; i++)
{
    array[i] = new Random() .Next(0,100);
    System.Console.WriteLine(array[i]);
}

for ( int i = 0; i < array.Length; i++)
{
    if ( max < array[i]) max = array[i];
}

int min = array[3];

for ( int j = 0; j < array.Length; j++)
{
    if ( min > array[j]) min = array[j];
}

int result = max - min;
System.Console.WriteLine($"Разницу между максимальным {max} и минимальным {min} элементами массива = {result}");
