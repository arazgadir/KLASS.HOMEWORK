using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    //1. Создать класс Point, разработав следующие элементы класса:
    //Поля:
    //int x, y;
    //Конструкторы, позволяющие создать экземпляр класса:
    //с нулевыми координатами;
    //с заданными координатами.
    //Методы, позволяющие:
    //вывести координаты точки на экран;
    //рассчитать расстояние от начала координат до точки;
    //переместить точку на плоскости на вектор(a, b).
    //Свойства:
    //получить-установить координаты точки(доступное для чтений и записи);
    //позволяющие умножить координаты точки на скаляр(доступное только для записи).


    class Point
    {

        public int X { get; set; }
    
        public int Y { get; set; }




    


        public Point()
        {

        }


        public Point(int x, int y)
        {
            X = x;
            Y = y;

        }

        public void GetInfo()
        {
            Console.WriteLine($"Абсцисса: {X} \nОрдината: {Y}");

        }

        public void GetDistance()
        {
            double distance = Math.Sqrt((X * X) + (Y * Y));
            Console.WriteLine($"Расстояние = {distance}");

        }

        public void GetQuarter()
        {
            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Точка в первой четверти");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Точка во второй четверти");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Точка в третей четверти");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Точка в четвертой четверти");
            }
            else
            {
                Console.WriteLine("Точка в начале координат");

            }


        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Point num = new Point();
            Console.Write("Введите значение X:  ");
            num.X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение Y:  ");
            num.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

           


            num.GetInfo();
            num.GetDistance();
            num.GetQuarter();


        }
    }
}