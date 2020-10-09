using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {     
        static void Main(string[] args)
        {
            Figure[] figure=new Figure[0];
            int Length = 2;
            try
            {
                CreateFigureArray(Length,ref figure);
                for (int i = 0; i < Length; i++)
                {
                    figure[i].Draw();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void CreateFigureArray(int Length,ref Figure[] Fig)
        {
            Fig=new Figure[Length];
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("Введите пожалуйста цифру в соответствии с требуемой фигурой");
                Console.WriteLine("1-Прямая,2-окружность, 3-прямоугольни, 4-круг, 5-кольцо");
                int NumFigure = int.Parse(Console.ReadLine());
                switch (NumFigure)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите длину прямой");
                            int length = int.Parse(Console.ReadLine());
                            Fig[i] = new Line(length);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Введите координату X окружности");
                            int xCenter = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите координату Y окружности");
                            int yCenter = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите Радиус окружности");
                            int radius = int.Parse(Console.ReadLine());
                            Fig[i] = new Circle(xCenter, yCenter, radius);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Введите длину прямоугольника");
                            int length = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите высоту прямоугольника");
                            int height = int.Parse(Console.ReadLine());
                            Fig[i] = new Rectangle(length, height);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Введите координату X круга");
                            int xCenter = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите координату Y круга");
                            int yCenter = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите Радиус круга");
                            int radius = int.Parse(Console.ReadLine());
                            Fig[i] = new Round(xCenter, yCenter, radius);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Введите координату X кольца");
                            int xCenter = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите координату Y кольца");
                            int yCenter = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите внутренний Радиус кольца");
                            int radius = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите внешний Радиус кольца");
                            int outerRadius = int.Parse(Console.ReadLine());
                            Fig[i] = new Ring(xCenter, yCenter, radius, outerRadius);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Вы ввели неверную цифру. Введите число от 1 до 5");
                        }
                    break;
                }
                
            }
            
        }
    }
    abstract class Figure
    {
        public abstract void Draw();
    } 
}
