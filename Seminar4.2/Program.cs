// Принимает число и выдает кол-во цифр в числе.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр в этом числе {Quantity(num)}");

int Quantity (int Array)
{
    int a = 2;
    
    for (int x = 1; x <= Array; x++)
    {
      a=a*1;
    }
    return a;
}