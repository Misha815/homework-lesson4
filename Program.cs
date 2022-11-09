//Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)
/* void PowNumber (int arg,int degree)
{
    int result = 1;
 for (int i = 0; i < degree; i++)
 {
    result = result * arg;
 }   
 Console.WriteLine(result);
}
Console.WriteLine("Введите число");
int numberArg = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int numberDegree = Convert.ToInt32(Console.ReadLine());

PowNumber(numberArg,numberDegree);
 */

 //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/* 
int NumberLength (int num)
{
    int indexNumber = 0;
    while (num > 0)
    {
        num /= 10;
        indexNumber++;
    }
    return indexNumber;
}


void NumberSum(int n,int Len)
{
    int sum = 0;
    for (int i = 0; i < Len; i++)
    {
      sum = sum + n%10; 
      n /= 10; 
    }
    Console.WriteLine(sum);
}

Console.WriteLine("Введите число");

int Number = Convert.ToInt32(Console.ReadLine());

int Length = NumberLength(Number);

NumberSum(Number,Length); */

//Задача 29: Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.

/* void GenerateMass(int size)
{
int[] array = new int[size];

Console.Write("|");
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(1,99);
   Console.Write($" {array[i]} |");
}
}

Console.Write("Введите размер массива: ");
int Number = Convert.ToInt32(Console.ReadLine());

GenerateMass(Number);
 */