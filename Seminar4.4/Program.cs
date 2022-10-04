// Выводит массив из 8 элементов, заполненный нулями и единицами в случ порядке.

int[] array = ArrayMethod(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] ArrayMethod (int size)
{
    int[] result = new int[size];
    for(int i=0; i<size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}