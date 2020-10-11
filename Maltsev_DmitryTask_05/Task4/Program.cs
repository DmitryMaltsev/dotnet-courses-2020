using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString result = new MyString("abc") + new MyString("bc");
            Console.WriteLine($"после вычитания получилась строка={result.ToString()}");
            result = new MyString("abc") - new MyString("bc");
            Console.WriteLine($"после вычитания получилась строка={result.ToString()}");                                                 
            bool IsEqual = (new MyString("abc") == new MyString("abc"));
            if(IsEqual)
            {
               Console.WriteLine("Строки равны");
            }
            else
            {
                Console.WriteLine("Строки не равны");
            }
        }
    }
}
