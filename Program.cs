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

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// void PrintSum(int M, int N, int result)
// {
//   result = result + N;
//   if (N <= M)
//   {
//     Console.Write($"Сумма чисел равна: {result}");
//     return;
//   }
//   if (M > N)
//   {
//     M = N;
//     Console.Write($"Сумма чисел равна: {N}");
//   }
//   PrintSum(M, N - 1, result);
// }
// PrintSum(M, N, result);



// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int akkermanFunction = Akkerman(m, n);
int Akkerman(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if(n == 0 && m > 0)
  {
    return Akkerman(m - 1, 1);
  }
  else
  {
    return Akkerman(m - 1, Akkerman(m, n - 1));
  }
}
Console.Write($"Результат вычисления функци Аккермана: {akkermanFunction}");
Akkerman(m, n);