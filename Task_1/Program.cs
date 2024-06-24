using System;

class MultiplicityChecker
{
    static void Main()
{
        Console.Write("Введите число для проверки: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 7 == 0 && number % 23 == 0)
        {
            Console.WriteLine("Число " + number + " кратно одновременно 7 и 23.");
        }
        else
        {
            Console.WriteLine("Число " + number + " не кратно одновременно 7 и 23.");
        }
        //=====================================
               Console.Write("Введите координату X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в первой координатной четверти.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во второй координатной четверти.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в третьей координатной четверти.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четвертой координатной четверти.");
        }
        else
        {
            Console.WriteLine("Точка находится на одной из осей координат, что противоречит условию X ≠ 0 и Y ≠ 0.");
        }
        // ====================================================
                Console.Write("Введите целое число от 10 до 99: ");
        int numbers = Convert.ToInt32(Console.ReadLine());

        if (numbers >= 10 && numbers <= 99)
        {
            int firstDigit = numbers / 10;
            int secondDigit = numbers % 10;
            int maxDigit = Math.Max(firstDigit, secondDigit);

            Console.WriteLine("Наибольшая цифра числа: " + maxDigit);
        }
        else
        {
            Console.WriteLine("Число не находится в указанном диапазоне.");
        }
        // ========================================================
                if (number > 0)
        {
            string numberString = number.ToString();
            string result = "";

            for (int i = 0; i < numberString.Length; i++)
            {
                result += numberString[i];
                if (i < numberString.Length - 1)
                {
                    result += ", ";
                }
            }

            Console.WriteLine("Цифры числа через запятую: " + result);
        }
        else
        {
            Console.WriteLine("Введенное число не является натуральным.");
        }
    }
    
}
