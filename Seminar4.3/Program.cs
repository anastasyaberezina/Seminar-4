// Принимает число N и выдает произведение чисел от 1 до N.

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Умножение цифр в промежутке от 1 до {N} равно {Multi(N)}");

int Multi (int length)
{ 
  int x = 1; 

  for (int i=1; i<=length; i++)
  {
    x= x*i;
  }
  return x;
}

  