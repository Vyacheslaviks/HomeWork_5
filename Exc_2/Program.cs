///Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//Тело программы

Console.WriteLine($"Четных чисел в масисве: {Search_Even_Numbers(Fill_Random_Array(100, 1000))}");

//Методы
int[] Fill_Random_Array(int min, int max)
{
    Random rand = new Random();
    int[] array = new int[10];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max);
    }

    string print_array = string.Join(", ", array);
    Console.WriteLine($"[{print_array}]");

    return array;
}

int Search_Even_Numbers(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}