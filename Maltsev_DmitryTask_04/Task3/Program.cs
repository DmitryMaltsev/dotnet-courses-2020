using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Date = DateTime.Now;
            double Value = 756248.6789;
            Console.Write("Введите цифру выбора варианта для сравнения:\n1) ru vs en\n2) en vs invariant\n3) ru vs invariant\n");
            int option = int.Parse(Console.ReadLine());
            ShowDifferenceBetweenCultures(Value, Date, option);

        }
        private static void ShowDifferenceBetweenCultures(double val, DateTime date, int NumComparison)
        {
            switch (NumComparison)
            {
                case 1:
                    {
                        Console.WriteLine("Формат даты и временной формат в русской культуре");
                        Console.WriteLine("Date format(long): {0}", date.ToString("D", CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine("Date format(short): {0}", date.ToString("d", CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine("Full format(long): {0}", date.ToString("F", CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine("Full format(short): {0}", date.ToString("f", CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine("Time format(long): {0}", date.ToString("T", CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine("Time format(short): {0}", date.ToString("t", CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine("General format (long):  {0}", date.ToString("G", CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine("General format (short): {0}", date.ToString("g", CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine();
                        Console.WriteLine("Формат даты и временной формат в английской культуре");
                        Console.WriteLine("Date format(long): {0}", date.ToString("D", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Date format(short): {0}", date.ToString("d", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Full format(long): {0}", date.ToString("F", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Full format(short): {0}", date.ToString("f", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Time format(long): {0}", date.ToString("T", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Time format(short): {0}", date.ToString("t", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("General format (long):  {0}", date.ToString("G", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("General format (short): {0}", date.ToString("g", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine();
                        Console.WriteLine("Формат числа в русской культуре");
                        Console.WriteLine("Резделитель дробной и разрядной частей: {0}", val.ToString("N", CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine("Валюта: {0}",val.ToString("C",CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine("Формат с фиксированной точкйо: {0}", val.ToString("F", CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine("В процентах: {0}", val.ToString("P", CultureInfo.GetCultureInfo("ru-RU")));
                        Console.WriteLine();
                        Console.WriteLine("Формат числа в английской культуре");
                        Console.WriteLine("Резделитель дробной и разрядной частей: {0}", val.ToString("N", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Валюта: {0}", val.ToString("C", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Формат с фиксированной точкой: {0}", val.ToString("F", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("В процентах: {0}", val.ToString("P", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    {
                  
                        Console.WriteLine("Формат даты и временной формат в английской культуре");
                        Console.WriteLine("Date format(long): {0}", date.ToString("D", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Date format(short): {0}", date.ToString("d", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Full format(long): {0}", date.ToString("F", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Full format(short): {0}", date.ToString("f", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Time format(long): {0}", date.ToString("T", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Time format(short): {0}", date.ToString("t", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("General format (long):  {0}", date.ToString("G", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("General format (short): {0}", date.ToString("g", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine();
                        Console.WriteLine("Формат даты и временной формат не зависящий от языка");
                        Console.WriteLine("Date format(long): {0}", date.ToString("D", CultureInfo.InvariantCulture));
                        Console.WriteLine("Date format(short): {0}", date.ToString("d", CultureInfo.InvariantCulture));
                        Console.WriteLine("Full format(long): {0}", date.ToString("F", CultureInfo.InvariantCulture));
                        Console.WriteLine("Full format(short): {0}", date.ToString("f", CultureInfo.InvariantCulture));
                        Console.WriteLine("Time format(long): {0}", date.ToString("T", CultureInfo.InvariantCulture));
                        Console.WriteLine("Time format(short): {0}", date.ToString("t", CultureInfo.InvariantCulture));
                        Console.WriteLine("General format (long):  {0}", date.ToString("G", CultureInfo.InvariantCulture));
                        Console.WriteLine("General format (short): {0}", date.ToString("g", CultureInfo.InvariantCulture));
                        Console.WriteLine();
                        Console.WriteLine("Формат числа в английской культуре");
                        Console.WriteLine("Резделитель дробной и разрядной частей: {0}", val.ToString("N", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Валюта: {0}", val.ToString("C", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("Формат с фиксированной точкой: {0}", val.ToString("F", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine("В процентах: {0}", val.ToString("P", CultureInfo.GetCultureInfo("en-EN")));
                        Console.WriteLine();
                        Console.WriteLine("Формат числа не зависящий от языка");
                        Console.WriteLine("Резделитель дробной и разрядной частей: {0}", val.ToString("N", CultureInfo.InvariantCulture));
                        Console.WriteLine("Валюта: {0}", val.ToString("C", CultureInfo.InvariantCulture));
                        Console.WriteLine("Формат с фиксированной точкой: {0}", val.ToString("F", CultureInfo.InvariantCulture));
                        Console.WriteLine("В процентах: {0}", val.ToString("P", CultureInfo.InvariantCulture));
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Формат даты и временной формат в русской культуре");
                    Console.WriteLine("Date format(long): {0}", date.ToString("D", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine("Date format(short): {0}", date.ToString("d", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine("Full format(long): {0}", date.ToString("F", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine("Full format(short): {0}", date.ToString("f", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine("Time format(long): {0}", date.ToString("T", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine("Time format(short): {0}", date.ToString("t", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine("General format (long):  {0}", date.ToString("G", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine("General format (short): {0}", date.ToString("g", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine();
                    Console.WriteLine("Формат даты и временной формат не зависящий от языка");
                    Console.WriteLine("Date format(long): {0}", date.ToString("D", CultureInfo.InvariantCulture));
                    Console.WriteLine("Date format(short): {0}", date.ToString("d", CultureInfo.InvariantCulture));
                    Console.WriteLine("Full format(long): {0}", date.ToString("F", CultureInfo.InvariantCulture));
                    Console.WriteLine("Full format(short): {0}", date.ToString("f", CultureInfo.InvariantCulture));
                    Console.WriteLine("Time format(long): {0}", date.ToString("T", CultureInfo.InvariantCulture));
                    Console.WriteLine("Time format(short): {0}", date.ToString("t", CultureInfo.InvariantCulture));
                    Console.WriteLine("General format (long):  {0}", date.ToString("G", CultureInfo.InvariantCulture));
                    Console.WriteLine("General format (short): {0}", date.ToString("g", CultureInfo.InvariantCulture));
                    Console.WriteLine();
                    Console.WriteLine("Формат числа в русской культуре");
                    Console.WriteLine("Резделитель дробной и разрядной частей: {0}", val.ToString("N", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine("Валюта: {0}", val.ToString("C", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine("Формат с фиксированной точкйо: {0}", val.ToString("F", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine("В процентах: {0}", val.ToString("P", CultureInfo.GetCultureInfo("ru-RU")));
                    Console.WriteLine();
                    Console.WriteLine("Формат числа не зависящий от языка");
                    Console.WriteLine("Резделитель дробной и разрядной частей: {0}", val.ToString("N", CultureInfo.InvariantCulture));
                    Console.WriteLine("Валюта: {0}", val.ToString("C", CultureInfo.InvariantCulture));
                    Console.WriteLine("Формат с фиксированной точкой: {0}", val.ToString("F", CultureInfo.InvariantCulture));
                    Console.WriteLine("В процентах: {0}", val.ToString("P", CultureInfo.InvariantCulture));
                    Console.WriteLine();
                    break;

            }
        }

    }
}
