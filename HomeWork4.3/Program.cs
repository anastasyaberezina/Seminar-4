// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine());

// int result = Convert.ToInt32(Math.Pow(x, y));
Console.WriteLine($"Число {A} в степени {B} равно {Method()}");

int Method (int x, int y)
{
    while ((x>0)&&(y>0))
    {
      int result = Convert.ToInt32(Math.Pow(x, y));
    }
    return result;
}