//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

//Тело программы

int[] local_array = GenRandomArray(0, 11); //создал отдельный массив что бы не вызывать метод генерации массива несколько раз

string out_array = string.Join(", ", local_array);

Console.WriteLine($"[{out_array}]");
Console.WriteLine($"Сумма элементов с нечетными индексами = {SumEvenNumbers(local_array)}");

//методы

int[] GenRandomArray(int min, int max)
{
    int[] array = new int [6];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max);
    }

    return array;
}

int SumEvenNumbers(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }

    return sum;
}