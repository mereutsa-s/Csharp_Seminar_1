using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число или 'q' для выхода:");

        while (true)
        {
            string input = Console.ReadLine();

            // Проверка на ввод 'q' для выхода из программы
            if (input.ToLower() == "q")
            {
                break;
            }

            // Попытка преобразовать введенное значение в целое число
            if (int.TryParse(input, out int number))
            {
                // Вычисление суммы цифр числа
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                // Проверка, является ли сумма цифр четным числом
                if (sum % 2 == 0)
                {
                    Console.WriteLine("Сумма цифр введенного числа четная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }

        Random random = new Random();
        int[] array = new int[10]; // Массив для хранения случайных чисел
        int evenCount = 0; // Счетчик четных чисел

        // Заполнение массива случайными трехзначными числами
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000); // Случайное число от 100 до 999
            Console.WriteLine(array[i]); // Вывод сгенерированного числа
        }

        // Подсчет количества четных чисел
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        // Вывод результата
        Console.WriteLine("Количество четных чисел в массиве: " + evenCount);
        int[] array = { 1, 2, 3, 4, 5 }; // Исходный массив
        int length = array.Length;

        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Переворот массива
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }

        // Вывод перевернутого массива
        Console.WriteLine("Перевернутый массив:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
