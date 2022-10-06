// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//Программу написала, но не могу разобраться, что не так.

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine()); //Считали число
int[] array = ArrayRandom(x); //присвоили массив
Console.WriteLine($"Сумма цифр данного числа {ArrayRandom(x)}");

int[] ArrayRandom (int size)
{
    int[] array2 = new int[size]; //присвоили пустому массиву size;
    int sum = 0;//переменная, хранящая искомую сумму
    array2[0] = size[0]; //Начало массива
    int sum2 = 0; //промежуточная сумма
    
    for(int index=0; index<size; index++) //текущая переменная
    {
       sum2 = array[0]+array[index];
       sum = sum+sum2;
    }
    return sum;
}