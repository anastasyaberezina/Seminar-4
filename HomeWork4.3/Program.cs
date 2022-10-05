// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Максимальное решение, на которое меня хватило.

Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
int i =                        // ? 2 числа вместе   
// string i = int.Parse(Console.ReadLine(A, B));
// int result = Convert.ToInt32(Math.Pow(x, y));
Console.WriteLine($"Число {A} в степени {B} равно {Method(i)}");

int Method (int numbers)
{   
  int a = numbers/10;
  int b = numbers%10;
  int result = 0;

  while ((a>0)&&(b>0))
  {
    result = Convert.ToInt32(Math.Pow(a, b));
  }
  return result;
}