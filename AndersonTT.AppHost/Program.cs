using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Babuk_CSharp
{
    class Program
    {
        static void Main()
        {
            // Если введенное число больше 7, то вывести “Привет”
            Console.WriteLine("Введите число:");
            CheckNumber(int.Parse(Console.ReadLine()));

            // Если введенное имя совпадает с “Вячеслав”, то вывести “Привет, Вячеслав”
            Console.WriteLine("Введите имя:");
            CheckName(Console.ReadLine());


            // На входе есть числовой массив, необходимо вывести элементы массива кратные 3
            Console.WriteLine("Введите последовательность чисел через запятую без пробелов:");
            PrintMultiplesOfThree(Console.ReadLine());
        }

        static void CheckNumber(int number)
        {
            if (number > 7)
                Console.WriteLine("Привет");
        }

        static void CheckName(string name)
        {

            if (name.Equals("Вячеслав"))
                Console.WriteLine("Привет, Вячеслав");
            else
                Console.WriteLine("Нет такого имени");
        }

        static void PrintMultiplesOfThree(string array)
        {
            string[] numbers = array.Split(",");
            foreach (string number in numbers)
            {
                int parsedNumber = int.Parse(number);
                if (parsedNumber % 3 == 0)

                    Console.Write(parsedNumber + " ");
            }

        }
    }

}