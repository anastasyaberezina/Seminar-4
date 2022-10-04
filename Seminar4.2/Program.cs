// Принимает число и выдает кол-во цифр в числе.

// Console.WriteLine("Введите число: ");
// string num = Console.ReadLine()!;
// Console.WriteLine($"Количество цифр в этом числе {Quantity(num)}");

// int Quantity (string length)
// { 
//   return length.Length;
// }


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в этом числе {Quantity(num)}");

int Quantity (int length)
{ 
  int sum = length; //кол-во цифр
  int count = 0; //переменная

  while (sum>0)
  {
    sum=sum/10;
    count=count+1;
  }
    return count;
}