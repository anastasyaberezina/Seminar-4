//Принимает на вход число A и выдает сумму чисел от 1 до A.

Console.WriteLine ("Введи число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {A} равна {GetSum(A)}");

int GetSum (int limit)
{
    int sum = 0;
    for (int i = 1; i<=limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}