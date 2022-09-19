//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int [10];

for (int i = 0; i < array.Length; i++)
{
        array[i] = new Random().Next (-100 , 100);
        System.Console.WriteLine(array[i]);
}
int sum = 0;

for (int j = 1; j < array.Length; j +=2)
{
    sum = sum + array[j];
}
System.Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {sum}");