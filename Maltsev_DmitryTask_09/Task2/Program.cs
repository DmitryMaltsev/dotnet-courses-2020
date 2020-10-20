using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Element element = new Element();
            Element[] arrayElements = new Element[8];
            DynamicArray<Element> elements = new DynamicArray<Element>(arrayElements);
            for (int i = 0; i < 10; i++)
            {
                elements.Add(element);
            }
            arrayElements = new Element[9];
            for (int i = 0; i < arrayElements.Length; i++)
            {
                arrayElements[i] = element;
            }
            elements.AddRange(arrayElements);
            if (elements.Remove(4))
            {
                Console.WriteLine("Значение из массива с индексом 4 было удалено");
            }
            try
            {
                elements.Insert(4, element);
                elements.Insert(5, element);
                Console.WriteLine($"Общая длина коллекции={elements.Capacity}");
                Console.WriteLine($"Количество непустых элеменов коллекции={elements.Length}");
                elements.Remove(10);
                Console.WriteLine($"Количество непустых элеменов коллекции={elements.Length}");
            }
            catch (ArgumentOutOfRangeException outRange)
            {
                Console.WriteLine($"Error: {outRange}");
            }
        }
    }


}



