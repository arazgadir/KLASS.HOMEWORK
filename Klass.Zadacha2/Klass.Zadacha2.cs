using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Zadacha4.Rekursiya
{

    //    2. Создать класс Triangle, разработав следующие элементы класса:
    //Поля:
    //int a, b, c;
    //    Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
    //    Методы, позволяющие:
    //вывести длины сторон треугольника на экран;
    //    рассчитать периметр треугольника;
    //рассчитать площадь треугольника.
    //Свойства:
    //позволяющее получить-установить длины сторон треугольника(доступное для чтения и записи);
    //    позволяющее установить, существует ли треугольник с данными длинами сторон(доступное только для чтения).


    class Tringle


    {
        private int a;
        private int b;
        private int c;

        public int StoronaA
        {
            set { a = value; }



            get { return a; }
        }
        public int StoronaB
        {
            set { b = value; }



            get { return b; }
        }
        public int StoronaC
        {
            set { c = value; }



            get { return c; }
        }


        public string Again
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                {
                    return "Отлично. Параметры верные";
                }
                else
                {
                    return "Неверные параметры. Введите заново.";
                }

            }

        }


        public Tringle()
        {

        }



        public Tringle(int A, int B, int C)
        {
            a = A;
            b = B;
            c = C;

        }

        public void GetSize()
        {
                Console.WriteLine("Длина стороны - a : " + a + " м.");
                Console.WriteLine("Длина стороны - b : " + b + " м.");
                Console.WriteLine("Длина стороны - c : " + c + " м.");
 
        }


        public void GetPerimetr()
        {
            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                Console.Write("Периметр: " + (a + b + c) + " м.");
            }
        }


        public void GetArea()
        {
            
                double p = (a + b + c) / 2;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Площадь: " + S + " квадратных м.");           

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Tringle T = new Tringle();



            do


            {
                Console.WriteLine("Введите стороны треугольника:\n ");

                Console.Write("Введите сторону - a :  ");
                T.StoronaA = int.Parse(Console.ReadLine());

                Console.Write("Введите сторону - b :  ");
                T.StoronaB = int.Parse(Console.ReadLine( ));

                Console.Write("Введите сторону - c :  ");
                T.StoronaC = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine(T.Again);

            } while (T.StoronaA <= 0 || T.StoronaB <= 0 || T.StoronaC <= 0
                    || T.StoronaA > T.StoronaB + T.StoronaC || T.StoronaB > T.StoronaA + T.StoronaC || T.StoronaC > T.StoronaA + T.StoronaB);


            T.GetSize();
            T.GetPerimetr();
            Console.WriteLine();
            T.GetArea();


            

        }
    }
}
