using System;
// ls_3
// class Palindrome
// {
//     static void Main()
//     {
//         string testString = "А роза упала на лапу Азора"; // Произвольная строка
//         Console.WriteLine($"Проверяемая строка: {testString}");
//         bool isPalindrome = IsPalindrome(testString);
//         Console.WriteLine(isPalindrome ? "Строка является палиндромом." : "Строка не является палиндромом.");
//     }

//     static bool IsPalindrome(string value)
//     {
//         string processedString = value.ToLower().Replace(" ", "");
//         char[] charArray = processedString.ToCharArray();
//         Array.Reverse(charArray);
//         string reversedString = new string(charArray);

//         return processedString == reversedString;
//     }
// }
// class LowercaseConverter
// {
//     static void Main()
//     {
//         string mixedCaseString = "HeLLo WorLD!"; // Заданная строка
//         Console.WriteLine($"Исходная строка: {mixedCaseString}");
        
//         string lowercaseString = mixedCaseString.ToLower();
//         Console.WriteLine($"Строка после преобразования: {lowercaseString}");
//     }
// }

// ls_1
// using System;
// using System.Text;

// class CharArrayToString
// {
//     static void Main()
//     {
//         // Задаем двумерный массив символов
//         char[,] charArray = {
//             {'H', 'e', 'l', 'l', 'o'},
//             {'W', 'o', 'r', 'l', 'd'},
//             {'C', 's', 'h', 'a', 'r', 'p'}
//         };

//         // Создаем строку из символов массива
//         string resultString = Convert2DArrayToString(charArray);
//         Console.WriteLine(resultString);
//     }

//     static string Convert2DArrayToString(char[,] array)
//     {
//         StringBuilder stringBuilder = new StringBuilder();

//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 stringBuilder.Append(array[i, j]);
//             }
//             // Добавляем пробел между строками массива для читаемости
//             stringBuilder.Append(' ');
//         }

//         return stringBuilder.ToString();
//     }
// }

// ls_2

// using System;
// using System.Text;

// class CharArrayToString
// {
//     static void Main()
//     {
//         // Задаем двумерный массив символов
//         char[,] charArray = {
//             {'H', 'e', 'l', 'l', 'o'},
//             {'W', 'o', 'r', 'l', 'd'},
//             {'C', 's', 'h', 'a', 'r'}
//         };

//         // Создаем строку из символов массива
//         string resultString = Convert2DArrayToString(charArray);
//         Console.WriteLine(resultString);
//     }

//     static string Convert2DArrayToString(char[,] array)
//     {
//         StringBuilder stringBuilder = new StringBuilder();

//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 stringBuilder.Append(array[i, j]);
//             }
//             // Добавляем пробел между строками массива для читаемости
//             stringBuilder.Append(' ');
//         }

//         return stringBuilder.ToString();
//     }
// }

// ls_4

// using System;

// class ReverseWords
// {
//     static void Main()
//     {
//         string originalString = "Пример строки с несколькими словами"; // Заданная строка
//         Console.WriteLine($"Исходная строка: {originalString}");
        
//         string reversedString = ReverseStringWords(originalString);
//         Console.WriteLine($"Строка с обратным порядком слов: {reversedString}");
//     }

//     static string ReverseStringWords(string str)
//     {
//         string[] words = str.Split(' ');
//         Array.Reverse(words);
//         return String.Join(" ", words);
//     }
// }
