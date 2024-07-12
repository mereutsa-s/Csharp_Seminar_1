// tz_1
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите значение M:");
//         int M = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите значение N:");
//         int N = int.Parse(Console.ReadLine());

//         Console.WriteLine("Натуральные числа в промежутке от {0} до {1}:", M, N);
//         PrintNaturalNumbers(M, N);
//     }

//     static void PrintNaturalNumbers(int M, int N)
//     {
//         if (M > N)
//         {
//             return;
//         }

//         if (M > 0)
//         {
//             Console.WriteLine(M);
//         }

//         PrintNaturalNumbers(M + 1, N);
//     }
// }

// tz_2

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите значение m:");
//         int m = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите значение n:");
//         int n = int.Parse(Console.ReadLine());

//         int result = Ackermann(m, n);
//         Console.WriteLine("Результат функции Аккермана для m = {0} и n = {1} равен {2}", m, n, result);
//     }

//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (m > 0 && n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else if (m > 0 && n > 0)
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//         else
//         {
//             throw new ArgumentOutOfRangeException("m и n должны быть неотрицательными числами.");
//         }
//     }
// }


// tz_3

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] array = { 1, 2, 3, 4, 5 };

//         Console.WriteLine("Элементы массива в обратном порядке:");
//         PrintArrayReverse(array, array.Length - 1);
//     }

//     static void PrintArrayReverse(int[] array, int index)
//     {
//         if (index < 0)
//         {
//             return;
//         }

//         Console.Write(array[index]);
//         PrintArrayReverse(array, index - 1);
//     }
// }
