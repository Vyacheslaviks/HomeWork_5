//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. 
//Не использовать готовые методы Min и Max

//тело программы

double[] local_array = GenRandomArray();

string out_array = string.Join(", ", local_array);
Console.WriteLine($"[{out_array}]");

int min_index = Search_min(local_array);
int max_index = Search_max(local_array);

Console.WriteLine($"Разница между максимальным и минималньым элементов массива: {CompareMaxMin(local_array, min_index, max_index)}");

//методы

double[] GenRandomArray()
{
    double[] array = new double[10];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble() * 10; //Генерируем числа в диапазоне от 0.0 до 10.0
    }

    return array;
}

int Search_min(double[] array)
{
    int j = 0;
    double min = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            j = i;
        }
    }

    return j;
}

int Search_max(double[] array)
{
    int j = 0;
    double max = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
            j = i;
        }
    }

    return j;
}

double CompareMaxMin(double[] array, int min_index, int max_index)
{
    double diff = array[max_index] - array[min_index];

    return diff;
}