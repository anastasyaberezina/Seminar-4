// Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

int[] array = ArrayRandom(8);
Console.WriteLine($"[{String.Join("; ", array)}]");

int[] ArrayRandom (int length)
{
    int[] result = new int[length];
    for(int i=0; i<length; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}