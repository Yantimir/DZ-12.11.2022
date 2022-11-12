// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void PrintNumbers(int number)
// {
//   if (number > 0)
//   {
//     Console.Write(number + ", "); 
//     number--;
//     PrintNumbers(number);
//   }
// }
// PrintNumbers(number);



// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
void PrintSum(int M, int N, int result)
{
  result = result + N;
  if (N <= M)
  {
    Console.Write($"Сумма чисел равна: {result}");
    return;
  }
  if (M > N)
  {
    M = N;
    Console.Write($"Сумма чисел равна: {N}");
  }
  PrintSum(M, N - 1, result);
}
PrintSum(M, N, result);
